package org.firstinspires.ftc.teamcode.positioning;

import org.firstinspires.ftc.teamcode.math.RevoPosition;

import java.util.ArrayList;

/**
 * Created by Victo on 5/6/2017.
 */

public class RevoPositionManager {
    public ArrayList<RevoPositionInput> Inputs;

    public RevoPositonGrid PositionGrid = new RevoPositonGrid();
    public void AddInput(RevoPositionInput in){
        Inputs.add(in);
    }
    public void Tick(){
        PositionGrid.Clear();

        for (int i = 0; i < Inputs.size(); i++) {
            RevoPositionInput input = Inputs.get(i);
            RevoPosition pos = input.GetPostion();

            PositionGrid.AddPosition(pos);
        }

        PositionGrid.Calculate();
    }
}
