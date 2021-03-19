import javax.imageio.ImageIO;
import java.awt.image.BufferedImage;
import java.io.File;

public class Miecz extends Broń {
    Miecz() {
        try {
            grafika = ImageIO.read(new File("sword.png"));
            grafikaAtaku = ImageIO.read(new File("swordAttack.png"));
            saveGrafiki = ImageIO.read(new File("sword.png"));
            grafikaR = ImageIO.read(new File("swordR.png"));
            grafikaAtakuAR = ImageIO.read(new File("swordAttackR.png"));
            saveGrafikiR = ImageIO.read(new File("swordR.png"));
        } catch (Exception e) {
            System.out.println("Miecz zdjecie: " + e);
        }
        silaAtaku = 10;
        zasięg = 70;
        strzelajaca = false;
    }
}
