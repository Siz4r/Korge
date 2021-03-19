import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

public class Kontroler  implements KeyListener, MouseListener {
    MainChamp main;
    int ticks;
   Kontroler(MainChamp main, int ticks) {
       this.ticks = ticks;
       this.main = main;
   }

    @Override
    public void keyPressed(KeyEvent e) {
        if (e.getKeyCode() == KeyEvent.VK_A) {
            main.nadajPredkosc(true);
            main.wRuchu = true;
        }
        if (e.getKeyCode() == KeyEvent.VK_D) {
            main.nadajPredkosc(false);
            main.wRuchu = true;
        }
        if (e.getKeyCode() == KeyEvent.VK_SPACE)
            main.skok();
        if (e.getKeyCode() == KeyEvent.VK_SHIFT)
            main.dodge();
    }

    @Override
    public void keyReleased(KeyEvent e) {
        if (e.getKeyCode() == KeyEvent.VK_A) {
            main.wRuchu = false;
        }
        if (e.getKeyCode() == KeyEvent.VK_D) {
            main.wRuchu = false;
        }
    }



    @Override
    public void mouseClicked(MouseEvent e) {
       main.attack(0,null);
    }
    @Override
    public void keyTyped(KeyEvent e) { }
    @Override
    public void mousePressed(MouseEvent e) { }
    @Override
    public void mouseReleased(MouseEvent e) { }
    @Override
    public void mouseEntered(MouseEvent e) { }
    @Override
    public void mouseExited(MouseEvent e) { }
}
