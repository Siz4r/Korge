import java.awt.Color
import java.awt.image.BufferedImage
import java.io.File
import javax.imageio.ImageIO
import kotlin.math.abs

class Drawing {
    lateinit var image: BufferedImage
    var width = 0
    var height = 0
    var red = 0.0
    var green = 0.0
    var blue = 0.0

    var r1: Double = 0.0
    var g1: Double = 0.0
    var b1: Double = 0.0
    var r2: Double = 0.0
    var g2: Double = 0.0
    var b2: Double = 0.0


    init {
        try {
            image = ImageIO.read(File("C:\\Users\\zaq13\\IdeaProjects\\GrafikaLaby\\Lab5\\src\\main\\kotlin\\kwiatek.jpg"))
            width = image.width
            height = image.height
        } catch (e: Exception) {
            println(e)
        }

    }

    fun mieszanieZdjec(doPolaczenia: BufferedImage, tryb: Int) {
        var cModified: Color
        val ouptut = File("grayscale.jpg")

        for (i in 0..height - 1) {
            for (j in 0..width - 1) {

                val colorFirstImage = Color(image.getRGB(j, i))
                val colorSecondImage = Color(doPolaczenia.getRGB(j, i))
                r1 = colorFirstImage.red / 255.0
                g1 = colorFirstImage.green / 255.0
                b1 = colorFirstImage.blue / 255.0
                r2 = colorSecondImage.red / 255.0
                g2 = colorSecondImage.green / 255.0
                b2 = colorSecondImage.blue / 255.0

                when {
                    tryb == 1 -> suma()
                    tryb == 2 -> odejmowanie()
                    tryb == 3 -> roznica()
                    tryb == 4 -> mnozenie()
                    tryb == 5 -> mnozenieOdwrotnosci()
                    tryb == 6 -> negacja()
                    tryb == 7 -> ciemniejsze()
                    tryb == 8 -> jasniejsze()
                    tryb == 9 -> wylaczenie()
                    tryb == 10 -> nakladka()
                    tryb == 11 -> ostreSwiatlo()
                    tryb == 12 -> lagodneSwiatlo()
                    tryb == 13 -> rozcienczenie()
                    tryb == 14 -> wypalanie()
                    tryb == 15 -> reflectMode()
                    tryb == 16 -> {
                        przezroczystosc(0.5)
                    }
                }

                cModified = Color(checkIfInBounds(red).toInt(), checkIfInBounds(green).toInt(), checkIfInBounds(green).toInt())
                image.setRGB(j, i, cModified.rgb)
            }
        }
        ImageIO.write(image, "jpg", ouptut)

    }

    fun transformacje(tryb: Int) {
        var cModified: Color
        val ouptut = File("grayscale.jpg")
        var a: Double
        var b: Double

        println("Podaj parametry(a i b): ")
        a = (readLine()?:"0").toDouble()
        b = (readLine()?:"0").toDouble()



        for (i in 0..height - 1) {
            for (j in 0..width - 1) {
                val c = Color(image.getRGB(j, i))
                when {
                    tryb == 1 -> {
                        modyfikujLiniowo(a, b, c)
                    }
                    tryb == 2 -> {
                        modyfikujPotegowo(a, b)
                    }
                }
                cModified = Color(red.toInt(), green.toInt(), blue.toInt())
                image.setRGB(j, i, cModified.rgb)

            }
        }
        ImageIO.write(image, "jpg", ouptut)
    }

    fun zmianiaKontrastu(delta:Int) {
        var cModified: Color
        val ouptut = File("grayscale.jpg")

        for (i in 0..height - 1) {
            for (j in 0..width - 1) {
                val c = Color(image.getRGB(j, i))
                red = if(c.red < 127) ((127 - delta) / 127.0) * c.red
                else ((127.0 - delta) / 127.0) * c.red + 2 * delta

                green = if(c.green < 127) ((127 - delta) / 127.0) * c.green
                else ((127.0 - delta) / 127.0) * c.green + 2 * delta

                blue = if(c.blue < 127) ((127 - delta) / 127.0) * c.blue
                else ((127.0 - delta) / 127.0) * c.blue + 2 * delta

                cModified = Color(checkIfInBounds(red / 255).toInt(),
                    checkIfInBounds(green / 255).toInt(),
                    checkIfInBounds(blue / 255).toInt())
                image.setRGB(j, i, cModified.rgb)

            }
        }
        ImageIO.write(image, "jpg", ouptut)
    }



    fun modyfikujLiniowo(a: Double, b: Double, c: Color) {
        red = if (a * c.red + b > 255.0) 255.0 else if (a * c.red + b < 0.0) 0.0 else a * c.red + b
        green = if (a * c.green + b > 255.0) 255.0 else if (a * c.green + b < 0.0) 0.0 else a * c.green + b
        blue = if (a * c.blue + b > 255.0) 255.0 else if (a * c.blue + b < 0.0) 0.0 else a * c.blue + b
    }

    fun modyfikujPotegowo(c: Double, n: Double) {
        red = Math.pow(c*red / 255.0, n) * 255.0
        green = Math.pow(c*green / 255.0, n) * 255.0
        blue = Math.pow(c*blue / 255.0, n) * 255.0
    }


    fun suma() {
        red = r1 + r2
        green = g1 + g2
        blue = b1 + b2
    }

    fun odejmowanie() {
        red = r1 + r2 - 1
        green = g1 + g2 - 1
        blue = b1 + b2 - 1
    }

    fun roznica() {
        red = abs(r1 - r2)
        green = abs(g1 - g2)
        blue = abs(b1 - b2)
    }

    fun mnozenie() {
        red = r1 * r2
        green = g1 * g2
        blue = b1 * b2
    }

    fun mnozenieOdwrotnosci() {
        red = 1 - (1 - r1) * (1 - r2)
        green = 1 - (1 - g1) * (1 - g2)
        blue = 1 - (1 - b1) * (1 - b2)
    }

    fun negacja() {
        red = 1 - abs(1 - r1 - r2)
        green = 1 - abs(1 - g1 - g2)
        blue = 1 - abs(1 - b1 - b2)
    }

    fun ciemniejsze() {
        red = if (r1 < r2) r1 else r2
        green = if (g1 < g2) g1 else g2
        blue = if (b1 < b2) b1 else b2
    }

    fun jasniejsze() {
        red = if (r1 > r2) r1 else r2
        green = if (g1 > g2) g1 else g2
        blue = if (b1 > b2) b1 else b2
    }

    fun wylaczenie() {
        red = r1 + r2 - 2.0 * r1 * r2
        green = g1 + g2 - 2.0*g1 * g2
        blue = b1 + b2 - 2.0*b1 * b2
    }

    fun nakladka() {
        red = if (r1 < 0.5) 2.0 * r1 * r2
                else 1 - 2.0 * (1 - r1) * (1 - r2)

        green = if (g1 < 0.5) 2.0 * g1 * g2
                else 1 - 2.0 * (1 - g1) * (1 - g2)

        blue = if (b1 < 0.5) 2.0 * b1 * b2
                else 1 - 2.0 * (1 - b1) * (1 - b2)
    }

    fun ostreSwiatlo() {
        red = if (r2 < 0.5) 2.0 * r1 * r2
        else 1 - 2.0 * (1 - r1) * (1 - r2)

        green = if (g2 < 0.5) 2.0 * g1 * g2
        else 1 - 2.0 * (1 - g1) * (1 - g2)

        blue = if (b2 < 0.5) 2.0 * b1 * b2
        else 1 - 2.0 * (1 - b1) * (1 - b2)
    }

    fun lagodneSwiatlo() {
        red = if (r2 < 0.5) 2.0 * r1 * r2 +
                Math.pow(r1, 2.0) * (1 - 2 * r2)
        else Math.sqrt(r1)*(2*r2 - 1) +
                (2*r1) * (1 - r2)

        green = if (g2 < 0.5) 2.0 * g1 * g2 +
                Math.pow(g1, 2.0) * (1 - 2 * g2)
        else Math.sqrt(g1)*(2*g2 - 1) +
                (2*g1) * (1 - g2)

        blue = if (b2 < 0.5) 2.0 * b1 * b2 +
                Math.pow(b1, 2.0) * (1 - 2 * b2)
        else Math.sqrt(b1)*(2*b2 - 1) +
                (2*b1) * (1 - b2)
    }

    fun rozcienczenie() {
        red = r1 / (1.0 - r2)
        green = g1 / (1.0 - g2)
        blue = g1 / (1.0 - g2)
    }

    fun wypalanie() {
        red = 1 - (1.0 - r1) / r2
        green = 1 - (1.0 - g1) / g2
        blue = 1 - (1.0 - b1) / b2
    }

    fun reflectMode() {
        red = Math.pow(r1, 2.0 / (1 - r2))
        green = Math.pow(g1, 2.0 / (1 - g2))
        blue = Math.pow(b1, 2.0 / (1 - b2))
    }

    fun przezroczystosc(temp: Double) {
        red = (1 - temp) * r2 + temp * r1
        green = (1 - temp) * g2 + temp * g1
        blue = (1 - temp) * b2 + temp * b1
    }

    fun checkIfInBounds(color: Double): Double {
        val temp = 255 * color
        if (temp > 255) return 255.0
        else if (temp < 0) return 0.0
        else return temp
    }

}