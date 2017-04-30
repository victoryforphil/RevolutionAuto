using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionCreator
{
    class AutoClasses
    {
    }


    /* 
     *HARDWARE
     */

    //Class to represent hardware item on the robot
    //Also parent to other hardware types
    public class HardwareItem
    {
        public string HardwareType;
        public string HardwareName;
        public string HardwareID;
        public bool   HardwareActive;
    }


    public class HardwareMotor : HardwareItem
    {
        public bool   MotorReversed;
        public double MotorScale;
    }
}
