using System;

namespace UDPsender
{
    class Program
    {
        static void Main(string[] args)
        {
            sender send = new sender();
            send.Start();
        }
    }
}
