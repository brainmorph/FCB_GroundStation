#Ground Station

Very basic GUI running on .NET to communicate with STM32F407 radio groundstation hardware.


Real-time altitude, pitch, roll, and yaw information from quadcopter is relayed over radio to STM32 ground station which communicates with GUI over UART to USB serial cable.  Additionally, USB controller commands are captured through the GUI and then forwarded to serial port to be sent to quadcopter.

![alt text](https://github.com/brainmorph/FCB_GroundStation/tree/master/ScreenShotGUI.PNG?raw=true)