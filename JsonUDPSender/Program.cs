using System;

namespace JsonUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSender worker = new JsonSender();

            worker.Start();
        }
    }
}
