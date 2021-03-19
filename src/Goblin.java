import javax.imageio.ImageIO;
import java.awt.*;
import java.io.File;
import java.util.Random;

public class Goblin extends Postac{
    int rasa = 1;
    int przyspieszenie;

    Goblin(int WIDTH, int HEIGHT, int szerokoscPostaci, int wysokoscPostaci) {
        przyspieszenie = new Random().nextInt(6) + 1;
        this.szerokoscPostaci = szerokoscPostaci;
        this.wysokoscPostaci = wysokoscPostaci;
        zycie = 100;
        bron = new Miecz();
        bron.blok = new Rectangle(WIDTH, HEIGHT, bron.zasięg, wysokoscPostaci);
        blok = new Rectangle(WIDTH, ziemia, szerokoscPostaci, wysokoscPostaci);
        rasa = new Random().nextInt(2) + 1;
        bron.zasięg += szerokoscPostaci;
        try {
            saveGrafiki = ImageIO.read(new File("Goblin" + rasa + ".png"));
            myImageA = ImageIO.read(new File("Goblin" + rasa + "A.png"));
            myImage = ImageIO.read(new File("Goblin" + rasa + ".png"));
            saveGrafikiR = ImageIO.read(new File("Goblin" + rasa + "R.png"));
            myImageAR = ImageIO.read(new File("Goblin" + rasa + "AR.png"));
            myImageR = ImageIO.read(new File("Goblin" + rasa + "R.png"));
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
        kogo.zycie -= bron.silaAtaku;
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
            if (xPredkosc > -przyspieszenie) xPredkosc -= 1;
        } else {
            if (xPredkosc < przyspieszenie) xPredkosc += 1;
        }
    }
}
