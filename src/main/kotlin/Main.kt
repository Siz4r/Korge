import java.awt.*

val curve = CurveBezzier()
var pFinal = Point(0,0)
var t = 0.0

fun main() {

}

fun repaint(g : Graphics) {
    g.color = Color.RED
    while (t < 1.01) {
        curve.cubicBezier(Point(81,92), Point(81,72), Point(114,68), Point(115,87),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(115,87), Point(116,102), Point(131,144), Point(115,197),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(115,197), Point(111,211), Point(183,155), Point(193,114),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(193,114), Point(197,99), Point(240,137), Point(226,142),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(226,142), Point(198,151), Point(156,222), Point(142,228),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(142,228), Point(114,241), Point(154,261), Point(140,255),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(140,255), Point(127,249), Point(219,300), Point(227,312),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(227,312), Point(245,339), Point(226,339), Point(210,334),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(210,334), Point(196,330), Point(97,246), Point(135,296),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(135,296), Point(144,308), Point(147,331), Point(132,342),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(132,342), Point(120,351), Point(94,368), Point(90,353),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)
        curve.cubicBezier(Point(90,353), Point(58,220), Point(82,78), Point(81,92),t)
        g.fillRect(pFinal.x,pFinal.y,4,4)

        print(pFinal.x)
        println("|${pFinal.y}")
        t += 0.001
    }

}


