import java.io.File
import java.math.BigDecimal
import java.math.RoundingMode
import java.util.*
import kotlin.math.pow

val matrix = Array(4) { Array(4) { ControlPoint(0.0,0.0,0.0) } }

fun main() {
    val input = File("C:\\Users\\zaq13\\IdeaProjects\\GrafikaLaby\\BezzierSurfaces\\src\\main\\kotlin\\ControlPoints.txt").bufferedReader()
    val output = File("C:\\Users\\zaq13\\IdeaProjects\\GrafikaLaby\\BezzierSurfaces\\src\\main\\kotlin\\ControlPointsConverted.txt").bufferedWriter()
    var skan = Scanner(input)
    var wynikX = 0.0
    var wynikY = 0.0
    var wynikZ = 0.0
    var u = 0.0
    var v = 0.0

    for (i in 0..input.readLine().toInt() - 1) {

        for (i in 0..3) {
            for (j in 0..3) {
                matrix[i][j] = ControlPoint(skan.next().toDouble(),skan.next().toDouble(),skan.next().toDouble())
                skan.nextLine()
            }
        }

        while (u <= 1.0) {
            while (v <= 1.0) {
                for (i in 0..3) {
                    for (j in 0..3) {
                        wynikX += matrix[i][j].x * berstein(3,i,v) * berstein(3,j,u)
                        wynikY += matrix[i][j].y * berstein(3,i,v) * berstein(3,j,u)
                        wynikZ += matrix[i][j].z * berstein(3,i,v) * berstein(3,j,u)
                    }
                }
                output.write("${BigDecimal(wynikX).setScale(4, RoundingMode.HALF_EVEN)} " +
                        "${BigDecimal(wynikY).setScale(4, RoundingMode.HALF_EVEN)} " +
                        "${BigDecimal(wynikZ).setScale(4, RoundingMode.HALF_EVEN)}\n")
                wynikX = 0.0
                wynikY = 0.0
                wynikZ = 0.0
                v+=0.01
            }
            v=0.0
            u+=0.01
        }
        u=0.0
    }
    output.close()
}

fun berstein(m: Int, i: Int, v: Double):Double {
    return dwumianNewtona(m,i)* v.pow(i.toDouble()) * (1 - v).pow((m - i).toDouble())
}

fun dwumianNewtona(n: Int, k: Int): Double {
    return silnia(n) / (silnia(k) * silnia(n - k)).toDouble()
}

fun silnia(n: Int): Int {
    var wynik = 1
    for(i in 1..n) {
        wynik*=i
    }
    return wynik
}