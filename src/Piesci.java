import javax.imageio.ImageIO;
import java.io.File;

public class Piesci extends Broń{
    Piesci() {
        silaAtaku = 20;
        zasięg = 0;
        strzelajaca = false;
        try {
            grafika = ImageIO.read(new File("Piesci.png"));
            grafikaAtaku = ImageIO.read(new File("Piesci.png"));
            saveGrafiki = ImageIO.read(new File("Piesci.png"));
            grafikaR = ImageIO.read(new File("Piesci.png"));
            grafikaAtakuAR = ImageIO.read(new File("Piesci.png"));
            saveGrafikiR = ImageIO.read(new File("Piesci.png"));
        } catch (Exception e) {
            System.out.println("Miecz zdjecie: " + e);
        }
    }
}
