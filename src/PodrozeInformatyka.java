import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.IOException;

public class PodrozeInformatyka implements ActionListener {
    public static PodrozeInformatyka podrozeInformatyka;
    int nr_bloku = 0;
    public Renderer renderer;
    public Kontroler kontroler;
    double ruchomeTlo;
    public int ticks;
    public int nastepnyAtak = 0;
    public final int WIDTH = 900, HEIGHT = 700;
    public Mapa mapa;
    MainChamp hero = new MainChamp(200, 310, 75, 100);
    JFrame jframe;

    PodrozeInformatyka() throws IOException {
        kontroler = new Kontroler(hero, ticks);
        Timer timer = new Timer(20, this);
        jframe = new JFrame();
        mapa = new Mapa();
        renderer = new Renderer();

        jframe.add(renderer);
        jframe.setVisible(true);
        jframe.setSize(WIDTH, HEIGHT);
        jframe.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jframe.addMouseListener(kontroler);
        jframe.addKeyListener(kontroler);
        jframe.setResizable(false);
        mapa.mapaBlokow.get(0).postacie.add(hero);
        timer.start();
    }

    public static void main(String[] args) throws IOException {
        podrozeInformatyka = new PodrozeInformatyka();
    }


    public void repaint(Graphics g) {
        g.setFont(new Font("Arial", 1, 20));
        g.drawImage(mapa.mapaBlokow.get(nr_bloku).tlo, 0 - (int) ruchomeTlo, 0, new ImagePanel(mapa.mapaBlokow.get(nr_bloku).tlo));
        mapa.mapaBlokow.get(nr_bloku).wyswieltBlok(g);
        for (Postac p :
                mapa.mapaBlokow.get(nr_bloku).postacie) {
            g.drawImage(p.myImage, p.blok.x, p.blok.y, p.szerokoscPostaci, p.wysokoscPostaci, new ImagePanel(p.myImageR));
            g.drawImage(p.bron.grafika, p.blok.x, p.blok.y + 20, p.bron.zasięg, p.wysokoscPostaci / 2, new ImagePanel(p.bron.grafikaR));
            if (!(p instanceof MainChamp))
                g.drawString(p.zycie + "", p.blok.x + (p.szerokoscPostaci / 2), p.blok.y - 10);
        }
        g.setColor(Color.WHITE);
        g.drawString("HP", 10, 20);
        g.setColor(Color.BLACK);
        g.drawRect(9, 29, 400 + 2, 32);
        g.setColor(Color.RED);
        g.fillRect(10, 30, hero.zycie * 2, 30);
        g.setFont(new Font("Arial", 5, 100));
        if (hero.zycie <= 0) {
            g.drawString("PORAZKA", HEIGHT / 2, WIDTH / 2);
        } else if (hero.zycie > 0 && mapa.mapaBlokow.get(4).postacie.get(0).equals(hero)) {
            g.drawString("Zwyciestwo", HEIGHT / 2, WIDTH / 2);
        }
        if (hero.blok.x + hero.xPredkosc < 0) {
            if (nr_bloku != 0) {
                nr_bloku--;
                hero.blok.x = WIDTH - hero.szerokoscPostaci - 5;
                mapa.mapaBlokow.get(nr_bloku).postacie.add(hero);
                mapa.mapaBlokow.get(nr_bloku + 1).postacie.remove(hero);
            } else {
                hero.xPredkosc = 0;
                hero.blok.x = 0;
            }
        } else if (hero.blok.x + hero.xPredkosc + hero.szerokoscPostaci >= WIDTH) {
            if (nr_bloku != mapa.mapaBlokow.size() - 1) {
                nr_bloku++;
                hero.blok.x = 0;
                mapa.mapaBlokow.get(nr_bloku).postacie.add(hero);
                mapa.mapaBlokow.get(nr_bloku - 1).postacie.remove(hero);
            } else {
                hero.xPredkosc = 0;
                hero.blok.x = WIDTH - hero.szerokoscPostaci;
            }
        }
    }


    @Override
    public void actionPerformed(ActionEvent e) {

        ticks++;
        if (nr_bloku == 6) ruchomeTlo = 0;
        else if (0 - ruchomeTlo <= 0) ruchomeTlo += hero.xPredkosc / 30; //Wypisywanie poruszajacego sie tla
        else
            ruchomeTlo = 0;
        for (Postac p :
                mapa.mapaBlokow.get(nr_bloku).postacie) {
            for (BlokZiemi b :
                    mapa.mapaBlokow.get(nr_bloku).tablicaBlokow) {
                if ((p.blok.x + p.szerokoscPostaci + p.xPredkosc >= b.x
                        && p.blok.x + p.szerokoscPostaci + p.xPredkosc <= b.x + p.xPredkosc) ///Jesli uderzymy w bok tekstury to zatrzymaj
                        && p.blok.y + p.wysokoscPostaci > b.y + 60) {
                    p.xPredkosc = 0;
                    p.blok.x -= 1;
                    if (!p.equals(hero)) {
                        p.skok();
                    }
                } else if ((p.blok.x + p.xPredkosc >= b.x + b.szerokoscBloku + p.xPredkosc //Tutaj od drugiej strony
                        && p.blok.x + p.xPredkosc <= b.x + b.szerokoscBloku)
                        && p.blok.y + p.wysokoscPostaci > b.y + 60) {
                    p.xPredkosc = 0;
                    p.blok.x += 1;
                    if (!p.equals(hero)) {
                        p.skok();
                    }
                }
                if (p.blok.x < b.x + b.szerokoscBloku && p.blok.x + p.szerokoscPostaci > b.x) { //Jesli trafimy na teksture od dolu to ustal nowa "ziemie"
                    if (b.y < p.wysokoscBloku) p.wysokoscBloku = b.y;
                    p.ziemia = p.wysokoscBloku - p.wysokoscPostaci + 60;
                }
            }
            if (!p.equals(hero)) {
                if (p instanceof Boss) {
                    if (p.blok.x < hero.blok.x && p.blok.x + p.szerokoscPostaci > hero.blok.x && p.yPredkosc == 0) { //Oblsuga bossa
                        p.attack(ticks, hero);
                    } else if ((p.blok.x - 200 <= hero.blok.x && p.blok.x + 200 >= hero.blok.x)) {
                        nastepnyAtak = 50;
                        p.skok();
                        if (ticks % 20 == 0) {
                            if (hero.myImage.equals(hero.myImageAR)) {
                                hero.myImage = hero.myImageR;
                            } else {
                                hero.myImage = hero.saveGrafiki;
                            }
                        }
                    }
                    if (p.blok.x < hero.blok.x && p.yPredkosc == 0) { //idzie w strone gracza
                        p.nadajPredkosc(false);
                    } else if (p.blok.x > hero.blok.x && p.yPredkosc == 0) {
                        p.nadajPredkosc(true);
                    }
                } else if (((p.blok.x + p.bron.zasięg - 30 >= hero.blok.x && p.blok.x <= hero.blok.x)
                        || (p.blok.x - p.bron.zasięg + 30 <= hero.blok.x && p.blok.x >= hero.blok.x)) && hero.blok.y - hero.wysokoscPostaci <= p.blok.y) {
                    if (!p.bron.grafika.equals(p.bron.grafikaAtaku) && nastepnyAtak == 0) { //Gobliny
                        nastepnyAtak = 50;
                        p.attack(ticks, hero);
                        if (ticks % 20 == 0) {
                            if (hero.myImage.equals(hero.myImageAR)) {
                                hero.myImage = hero.myImageR;
                            } else {
                                hero.myImage = hero.saveGrafiki;
                            }
                        }
                    }
                }
                if (p.blok.x < hero.blok.x && p.yPredkosc == 0) {
                    p.nadajPredkosc(false);
                } else if (p.blok.x > hero.blok.x && p.yPredkosc == 0) {
                    p.nadajPredkosc(true);
                }
            }
            if (ticks % 50 == 0 && !(p instanceof Boss)) {
                if (p.bron.grafika.equals(p.bron.grafikaAtakuAR) || p.bron.grafika.equals(p.bron.grafikaR)) {
                    p.bron.grafika = p.bron.grafikaR;
                } else {
                    p.bron.grafika = p.bron.saveGrafiki;
                }
            }
            p.wykonajRuch(ticks);
            if (hero.atakuje && !p.equals(hero)) { //Obsluga ataku gracza
                if (((p.blok.x <= hero.blok.x + hero.bron.zasięg && p.blok.x >= hero.blok.x) ||
                        (p.blok.x >= hero.blok.x - hero.bron.zasięg && p.blok.x <= hero.blok.x)) && hero.blok.y - p.blok.y < 150) {
                    p.zycie -= hero.bron.silaAtaku;
                    p.myImage = p.myImageA;
                    if (p.blok.x < hero.blok.x) {
                        p.xPredkosc = -11;
                    } else {
                        p.xPredkosc = 11;
                    }
                    hero.atakuje = false;
                }
            }
            if (ticks % 50 == 0 && hero.atakuje == true && !p.equals(hero)) {
                hero.atakuje = false;
                p.myImage = p.saveGrafiki;
            }
            p.wysokoscBloku = 900;

        }
        for (int i = 0; i < mapa.mapaBlokow.get(nr_bloku).postacie.size(); i++) {
            if (mapa.mapaBlokow.get(nr_bloku).postacie.get(i).zycie <= 0) {
                mapa.mapaBlokow.get(nr_bloku).postacie.remove(i);
            }
        }
        if (nastepnyAtak > 0) nastepnyAtak--;
        renderer.repaint();
    }

}
