using System;

namespace JsonUDPReciever
{
    class Program
    {
        static void Main(string[] args)
        {
            Reciever worker = new Reciever();
            worker.Start();
        }
    }
}
