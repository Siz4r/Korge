import java.awt.Color
import java.awt.Graphics
import java.awt.Point
import java.awt.event.ActionEvent
import java.awt.event.ActionListener
import javax.swing.JFrame
import javax.swing.Timer

class CurveBezzier {
    var renderer = Renderer()
    var jFrame = JFrame()
    init {
        jFrame.setSize(800,800)
        jFrame.setVisible(true)
        jFrame.defaultCloseOperation = JFrame.EXIT_ON_CLOSE
        jFrame.add(renderer)
        renderer.repaint()
    }
    fun cubicBezier(p0: Point, p1: Point, p2: Point, p3: Point, t: Double) {
        pFinal.x = (Math.pow(1 - t, 3.0) * p0.x + Math.pow(1-t, 2.0) * 3 * t * p1.x + (1 - t) * 3 * t * t * p2.x + t * t * t * p3.x).toInt()
        pFinal.y = (Math.pow(1 - t, 3.0) * p0.y + Math.pow(1-t, 2.0) * 3 * t * p1.y + (1 - t) * 3 * t * t * p2.y + t * t * t * p3.y).toInt()
    }

    fun silnia(n: Int): Double {
        var wynik = 1
        for (i in 2..n) {
            wynik*=i
        }
        return wynik.toDouble()
    }

    fun newton(n: Int, i: Int): Double {
        return silnia(n)/(silnia(i)*silnia(n-i))
    }

}