using System;

namespace ClassDemoEchoUDP
{
    class Program
    {
        static void Main(string[] args)
        {


            UdpServer worker = new UdpServer();
            worker.Start();
        }
    }
}
