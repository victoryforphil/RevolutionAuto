using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionCreator
{
    public static class AutoConsts
    {
        public static string HARDWARE_MOTOR = "Motor";
        public static string HARDWARE_SERVO = "Servo";
        public static string HARDWARE_ULTRASONIC = "Ultrasonuc";
        public static string HARDWARE_GRYO = "Gyro";

        public static string[] HARDWARE_ALL = { HARDWARE_MOTOR, HARDWARE_SERVO, HARDWARE_ULTRASONIC, HARDWARE_GRYO };

        public static string STEP_DRIVE = "Drive";
        public static string STEP_TURN = "Turn";
        public static string STEP_WAIT = "Wait";
        public static string STEP_ACTION = "Action";
        public static string STEP_CHOICE = "Choice";
        public static string STEP_SOUND = "Sound";

        public static string[] STEP_ALL = { STEP_DRIVE, STEP_TURN, STEP_WAIT, STEP_ACTION, STEP_SOUND };
    }
}
