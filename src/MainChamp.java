import javax.imageio.ImageIO;
import java.awt.*;
import java.io.File;

public class MainChamp extends Postac {
    boolean atakuje = false;

    MainChamp(int WIDTH, int HEIGHT, int szerokoscPostaci, int wysokoscPostaci) {
        this.szerokoscPostaci = szerokoscPostaci;
        this.wysokoscPostaci = wysokoscPostaci;
        bron = new Miecz();
        blok = new Rectangle(WIDTH, HEIGHT, szerokoscPostaci, wysokoscPostaci);
        bron.blok = new Rectangle(WIDTH, HEIGHT, bron.zasięg, wysokoscPostaci);
        bron.zasięg += szerokoscPostaci;
        try {
            myImage = ImageIO.read(new File("mainChamp.png"));
            myImageA = ImageIO.read(new File("mainChampA.png"));
            saveGrafiki = ImageIO.read(new File("mainChamp.png"));
            myImageR = ImageIO.read(new File("mainChampR.png"));
            myImageAR = ImageIO.read(new File("mainChampAR.png"));
            saveGrafikiR = ImageIO.read(new File("mainChampR.png"));
        } catch (Exception e) {
            System.out.println("Grafika glownej postaci: " + e);
        }

        zycie = 200;
    }

    @Override
    public void attack(int ticks, Postac kogo) {
        if (bron.grafika.equals(bron.grafikaR) || bron.grafika.equals(bron.grafikaAtakuAR)) {
            bron.grafika = bron.grafikaAtakuAR;
        } else {
            bron.grafika = bron.grafikaAtaku;
        }
        atakuje = true;
    }

    @Override
    public void dodge() {
        if (xPredkosc > -9 && xPredkosc < 9) {
            if (xPredkosc < 0) xPredkosc = -20;
            else xPredkosc = 20;
        }
    }

    @Override
    public void zwolnijRuch(int ticks) { {
            if (xPredkosc < 0 && ticks % 5 == 0) {
                xPredkosc += 1;
            }
            if (xPredkosc > 0 && ticks % 5 == 0) {
                xPredkosc -= 1;
            }
        }
    }

    @Override
    public void nadajPredkosc(boolean wlewo) {
        if (wlewo) {
            if (xPredkosc > -9) xPredkosc -= 1;
        } else {
            if (xPredkosc < 9) xPredkosc += 1;
        }
    }


}
