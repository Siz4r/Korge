import java.awt.*;
import java.awt.image.BufferedImage;
import java.util.ArrayList;

public class BlokiMapy {
    public BufferedImage tlo;
    public ArrayList<Postac> postacie;
    public ArrayList<BlokZiemi> tablicaBlokow;
    public ArrayList<Drzewa> drzewa;

    BlokiMapy(ArrayList<BlokZiemi> tablicaBlokow, ArrayList<Drzewa> drzewa) {
        postacie = new ArrayList<>();
        this.tablicaBlokow = new ArrayList<>(tablicaBlokow);
        this.drzewa = new ArrayList<>(drzewa);
    }

    public void wyswieltBlok(Graphics g){
        for (BlokZiemi b:
             tablicaBlokow) {
            b.wyswietlBlokZiemi(g);
        }
        for (Drzewa d:
             drzewa) {
            d.wyswietlDrzewo(g);
        }
    }
}
