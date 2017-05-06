package org.firstinspires.ftc.teamcode.positioning.methods;

import org.firstinspires.ftc.teamcode.math.RevoPosition;
import org.firstinspires.ftc.teamcode.positioning.RevoPositionInput;

/**
 * Created by Victo on 5/6/2017.
 */

public class RevoPositionStatic extends RevoPositionInput {

    @Override
    public RevoPosition GetPostion() {
        RevoPosition pos = new RevoPosition();
        pos.Certaincy = 0.88;
        pos.X = 500;
        pos.Y = 500;
        return super.GetPostion();
    }
}
