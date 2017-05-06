
package org.firstinspires.ftc.teamcode.opmodes.debugging;

import com.qualcomm.robotcore.eventloop.opmode.OpMode;
import com.qualcomm.robotcore.eventloop.opmode.TeleOp;
import com.qualcomm.robotcore.hardware.Servo;
import com.qualcomm.robotcore.hardware.UltrasonicSensor;
import com.qualcomm.robotcore.util.ElapsedTime;

import org.firstinspires.ftc.teamcode.old.TitanDebuger;
import org.firstinspires.ftc.teamcode.positioning.RevoPositionInput;
import org.firstinspires.ftc.teamcode.positioning.RevoPositionManager;
import org.firstinspires.ftc.teamcode.positioning.methods.RevoPositionStatic;

import java.util.HashMap;


@TeleOp(name="Revolution Position Test", group="Iterative Opmode")  // @Autonomous(...) is the other common choice

public class RevoOpDebugPositon extends OpMode
{
    /* Declare OpMode members. */
    private ElapsedTime runtime = new ElapsedTime();
    private RevoPositionStatic TestPos = new RevoPositionStatic();
    private RevoPositionManager PosManager = new RevoPositionManager();



    /*
     * Code to run ONCE when the driver hits INIT
     */

    @Override
    public void init() {
        telemetry.addData("Status", "Initialized");


       PosManager.AddInput(TestPos);


    }

    /*
     * Code to run REPEATEDLY after the driver hits INIT, but before they hit PLAY
     */
    @Override
    public void init_loop() {

    }

    /*
     * Code to run ONCE when the driver hits PL+AY
     */
    @Override
    public void start() {
        runtime.reset();
    }

    /*
     * Code to run REPEATEDLY after the driver hits PLAY but before they hit STOP
     */
    @Override
    public void loop() {
        PosManager.Tick();


    }
    /*
     * Code to run ONCE after the driver hits STOP
     */
    @Override
    public void stop() {

    }

}
