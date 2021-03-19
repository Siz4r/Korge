import java.awt.Graphics
import javax.swing.JPanel

class Renderer: JPanel() {
    override fun paintComponent(g: Graphics) {
        super.paintComponent(g)
        repaint(g)
    }
}