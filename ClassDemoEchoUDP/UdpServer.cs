using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClassDemoEchoUDP
{
    internal class UdpServer
    {
        private const int PORT = 7007;

        public void Start()
        {
            UdpClient client = new UdpClient(7007);

            Console.WriteLine("UDP receiver started på port" + PORT );

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, PORT);

            while (true)
            {
               byte[] bytes =  client.Receive(ref endpoint);
               string str = Encoding.UTF8.GetString(bytes);

               Console.WriteLine("Modtaget: " + str);
               string upperStr = str.ToUpper();


               byte[] buffer = Encoding.UTF8.GetBytes(upperStr.ToCharArray(), 0 , upperStr.Length);


               client.Send(buffer, buffer.Length, endpoint);

               
            }
        }
    }
}
