import com.soywiz.klock.seconds
import com.soywiz.klock.*
import com.soywiz.klogger.AnsiEscape
import com.soywiz.korge.*
import com.soywiz.korge.view.*
import com.soywiz.korim.color.*
import com.soywiz.korge.animate.*
import com.soywiz.korge.debug.UiTextEditableValue
import com.soywiz.korge.input.*
import com.soywiz.korio.async.*
import kotlinx.coroutines.*

suspend fun main() = Korge(width = 506, height = 506, bgcolor = Colors["#2b2b2b"]) {
	val rect1 = solidRect(100, 100, Colors.RED)
	val rect2 = solidRect(100, 100, Colors.BLUE)
	val circle  = Circle(26.0,Colors.GOLD).xy(450.0,450.0)
	var job: Job
	addChild(circle)


	while (true) {
		job = launchImmediately {
			animate(completeOnCancel = true) {
				sequence(time = 1.seconds, speed = 256.0) {
					wait(0.25.seconds)
					parallel {
						circle.moveBy(-450.0,-450.0)
						rect1.moveToWithSpeed(512.0 - 100, 0.0)
						rect2.moveToWithSpeed(0.0, 512.0 - 100 - 100)
					}
					parallel {

						rect1.moveTo(512.0 - 100, 512.0 - 100)
						rect2.moveTo(512.0 - 100, 512.0 - 100)
					}
					parallel(time = 1.seconds) {
						circle.moveBy(450.0,450.0)
						rect1.hide()
						rect2.hide()
					}
					block {
						rect1.position(0, 0)
						rect2.position(0, 0)
					}
					parallel(time = 0.5.seconds) {
						rect1.show()
						rect2.show()
					}
				}
			}
		}
		delay(3.seconds)
		job.join()
	}
}
