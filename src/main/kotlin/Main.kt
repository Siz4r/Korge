import java.awt.image.BufferedImage
import java.io.File
import javax.imageio.ImageIO

var image: BufferedImage = ImageIO.read(File("C:\\Users\\zaq13\\IdeaProjects\\GrafikaLaby\\Lab5\\src\\main\\kotlin\\róża.jpg"))

fun main() {
    val start = Drawing()
    var opcja: Int
        println("1. Mieszanie\n" +
                "2. Transformacja")
        opcja = (readLine()?:"1").toInt()
        if (opcja == 1) {
            println("Ktora opcja?:\n  " +
                    "1 -> suma\n" +
                    "2 -> odejmowanie\n" +
                    "3 -> roznica\n" +
                    "4 -> mnozenie\n" +
                    "5 -> mnozenieOdwrotnosci\n" +
                    "6 -> negacja\n" +
                    "7 -> ciemniejsze\n" +
                    "8 -> jasniejsze\n" +
                    "9 -> wylaczenie\n" +
                    "10 -> nakladka\n" +
                    "11 -> ostreSwiatlo\n" +
                    "12 -> lagodneSwiatlo\n" +
                    "13 -> rozcienczenie\n" +
                    "14 -> wypalanie\n" +
                    "15 -> reflectMode\n" +
                    "16 -> Przezroczystosc")
            opcja = (readLine()?:"1").toInt()
            start.mieszanieZdjec(image,opcja)
        } else {
            println("Ktora opcja?:\n" +
                    "1 -> Liniowo\n" +
                    "2 -> Potegowo\n")
            opcja = (readLine()?:"1").toInt()
            start.transformacje(opcja)
        }

//    start.zmianiaKontrastu(100)

}
