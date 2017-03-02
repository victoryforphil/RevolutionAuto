using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionCreator
{
    public static class ConnectionFunctions
    {
        public static bool isPhoneConnected = false;
        public static int ServerPort = 7777;


        // Returns the Local IP of the PC
        public static string GetLocalIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "error";
        }

    }
}
