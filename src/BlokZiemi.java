import javax.imageio.ImageIO;
import java.awt.*;
import java.awt.image.BufferedImage;
import java.io.File;

public class BlokZiemi {
    BufferedImage zdjecie;
    int x,y,szerokoscBloku,wysokoscBloku;
    Rectangle blok;

    BlokZiemi(int x, int y, int szerokoscBloku, int wysokoscBloku, String sciezkaDoZdjecia){
        this.x = x;
        this.y = y;
        this.szerokoscBloku = szerokoscBloku;
        this.wysokoscBloku = wysokoscBloku;
        blok = new Rectangle(x,y, szerokoscBloku, wysokoscBloku);
        try {
            zdjecie = ImageIO.read(new File(sciezkaDoZdjecia));
        } catch (Exception e) {
            System.out.println("Grafika bloku ziemi: " + e);
        }
    }

    public void wyswietlBlokZiemi(Graphics g) {
        g.drawImage(zdjecie, x, y, szerokoscBloku, wysokoscBloku, new ImagePanel(zdjecie));

    }
}
