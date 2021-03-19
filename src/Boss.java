import javax.imageio.ImageIO;
import java.awt.*;
import java.io.File;
import java.util.Random;

public class Boss extends Postac{
    private final int silaAtaku = 20;

    Boss(int WIDTH, int HEIGHT, int szerokoscPostaci, int wysokoscPostaci) {
        this.szerokoscPostaci = szerokoscPostaci;
        this.wysokoscPostaci = wysokoscPostaci;
        zycie = 100;
        bron = new Piesci();
        bron.blok = new Rectangle(WIDTH, HEIGHT, bron.zasięg, wysokoscPostaci);
        blok = new Rectangle(WIDTH, ziemia, szerokoscPostaci, wysokoscPostaci);
        bron.zasięg += szerokoscPostaci;
        try {
            saveGrafiki = ImageIO.read(new File("Boss.png"));
            myImageA = ImageIO.read(new File("BossA.png"));
            myImage = ImageIO.read(new File("Boss.png"));
            saveGrafikiR = ImageIO.read(new File("Boss.png"));
            myImageAR = ImageIO.read(new File("BossA.png"));
            myImageR = ImageIO.read(new File("Boss.png"));
        } catch (Exception e) {
            System.out.println("Goblin zdjecie: " + e);
        }
    }
    @Override
    public void attack(int ticks, Postac kogo) {
        if (xPredkosc <= 0) {
            bron.grafikaR = bron.grafikaAtakuAR;
        } else {
            bron.grafika = bron.grafikaAtaku;
        }
        kogo.zycie -= this.silaAtaku;
        this.skok();
        if (kogo.blok.x > this.blok.x)
        {
            kogo.myImage = kogo.myImageA;
        } else {
            kogo.myImage = kogo.myImageAR;
        }
    }


    @Override
    public void dodge() {

    }

    @Override
    public void zwolnijRuch(int ticks) {
        if (xPredkosc < 0 && ticks % 5 == 0) {
            xPredkosc += 1;
        }
        if (xPredkosc > 0 && ticks % 5 == 0) {
            xPredkosc -= 1;
        }
    }

    @Override
    public void nadajPredkosc(boolean wlewo) {
        if (wlewo) {
            if (xPredkosc > -8) xPredkosc -= 8;
        } else {
            if (xPredkosc < 8) xPredkosc += 8;
        }
    }

    @Override
    public void skok() {
        if (yPredkosc == 0) {
            blok.y -= 2;
            if (yPredkosc > 0) yPredkosc = 0;
            if (!(yPredkosc < 0)) yPredkosc -= 21;
        }
    }
}
