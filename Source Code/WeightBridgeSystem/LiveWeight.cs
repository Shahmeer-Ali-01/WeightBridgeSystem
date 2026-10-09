using System.IO.Ports;
using System;


namespace WeightBridgeSystem
{
    public static class LiveWeight
    {
        public static SerialPort Port = new SerialPort();
        public static string CurrentWeight = "0";
        public static bool IsConnected = false;
    }
}
