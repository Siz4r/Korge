import java.awt.*;
import java.awt.image.BufferedImage;


public abstract class Postac {
    public BufferedImage myImage, myImageA, saveGrafiki;
    public BufferedImage myImageR, myImageAR, saveGrafikiR;
    boolean wRuchu = false;
    public int ziemia = 405;
    int szerokoscPostaci;
    int wysokoscPostaci;
    int wysokoscBloku = 900;
    Broń bron;
    int zycie;
    double xPredkosc;
    double yPredkosc;
    Rectangle blok;

    public abstract void attack(int ticks, Postac kogo);
    public abstract void dodge();
    public abstract void zwolnijRuch(int ticks);
    public void skok() {
        if (yPredkosc == 0)
        {
            blok.y -= 2;
            if (yPredkosc > 0) yPredkosc = 0;
            if (!(yPredkosc < 0)) yPredkosc -= 15;
        }
    }
    public abstract void nadajPredkosc(boolean wlewo);
    public void grawitacja(int ticks) {
        if (ticks % 2 == 0 && yPredkosc < 15) {
            yPredkosc += 2;
        } if ( blok.y > ziemia || blok.y + yPredkosc > ziemia ) {
            blok.y = ziemia;
            yPredkosc = 0;
        }
    };
    public void wykonajRuch( int ticks ) {
        if (xPredkosc < 0) {
            myImage = saveGrafiki;
            bron.grafika = bron.saveGrafiki;
        } else if (xPredkosc > 0) {
            myImage = myImageR;
            bron.grafika = bron.grafikaR;
        }
        grawitacja(ticks);
        blok.y += yPredkosc;
        blok.x += xPredkosc;
        if (!wRuchu)
            zwolnijRuch(ticks);
        if (xPredkosc < -9 || xPredkosc > 9) wRuchu = false;
    }
}
