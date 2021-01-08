using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GroundStation
{
    class CommandInput
    {
        private static Timer timer;

        private struct Commands
        {
            public float throttleCMD;
            public float pitchCMD;
            public float rollCMD;
            public float yawCMD;
            public bool aux1;
            public bool aux2;
        }

        private static Commands commands;

        public CommandInput()
        {
            /* Zero out all commands */
            commands.throttleCMD = 0.0f;
            commands.pitchCMD = 0.0f;
            commands.rollCMD = 0.0f;
            commands.yawCMD = 0.0f;
            commands.aux1 = false;
            commands.aux2 = false;

            /* Create timer */
            timer = new Timer(30); // create with interval in [ms]
            timer.AutoReset = true;
            timer.Enabled = true;

            timer.Elapsed += OnTimedEvent; // attach event handler
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            /* Turn off timer if controller is not plugged in */
            if (BrandonPotter.XBox.XBoxController.GetConnectedControllers().Count() <= 0)
            {
                timer.Enabled = false;
                return;
            }

            commands.aux1 = BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault().ButtonAPressed;
            commands.aux2 = BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault().ButtonBPressed;

            commands.throttleCMD = (float)BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault().ThumbLeftY;
            commands.pitchCMD = (float)BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault().ThumbRightY;
            commands.rollCMD = (float)BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault().ThumbRightX;
            commands.yawCMD = (float)BrandonPotter.XBox.XBoxController.GetConnectedControllers().FirstOrDefault().ThumbLeftX;
        }

        /* Public Methods */
        public bool ControllerIsConnected()
        {
            var connectedControllers = BrandonPotter.XBox.XBoxController.GetConnectedControllers();
            //Debug.WriteLine(connectedControllers.ToString());
            //Debug.WriteLine($"Available controllers: {connectedControllers.Count()}");

            if (BrandonPotter.XBox.XBoxController.GetConnectedControllers().Count() > 0)
                return true;
            else
                return false;
        }
        public void StartReadingControllerInput()
        {
            timer.Enabled = true;
        }

        public float GetThrottleInput()
        {
            return commands.throttleCMD;
        }
        public float GetPitchInput()
        {
            return commands.pitchCMD;
        }
        public float GetRollInput()
        {
            return commands.rollCMD;
        }
        public float GetYawInput()
        {
            return commands.yawCMD;
        }
        public bool GetAux1Input()
        {
            return commands.aux1;
        }
        public bool GetAux2Input()
        {
            return commands.aux2;
        }
    }
}
