package org.firstinspires.ftc.teamcode.positioning;

import org.firstinspires.ftc.teamcode.math.RevoPosition;

import java.util.ArrayList;

/**
 * Created by Victo on 5/6/2017.
 */

public class RevoPositonGrid {
    public float[][] Grid;
    public ArrayList<RevoPosition> CurrentPositions = new ArrayList<>();

    public void AddPosition(RevoPosition pos){
        CurrentPositions.add(pos);
    }

    public void Calculate(){
        for (int i = 0; i < CurrentPositions.size(); i++) {
            RevoPosition _cur = CurrentPositions.get(i);

            int baseX = (int)Math.round(_cur.X);
            int baseY = (int)Math.round(_cur.Y);

            int range = (int)_cur.ErrorRange;

            double curGridVal = Grid[baseX][baseY];

            Grid[baseX][baseY] = (float)(curGridVal + _cur.Certaincy) / 2;
        }
    }

    public void Clear(){
        CurrentPositions.clear();
        for (int index = 0; index < Grid.length; index++) {
            for (int inner = 0; inner < Grid[index].length; inner++) {
                Grid[index][inner] = 0.0f;
            }
            Grid[index] = null;
        }
        Grid = null;

    }
}
