using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Modellibrary;

namespace UDPsender
{
    public class sender
    {
        

        public void Start()
        {
            UdpClient client = new UdpClient();

            Car car = new Car("Tesla","Red","Ar62969");

            Console.WriteLine("Ready to send on port: " + 7007);
            Console.Write(">");

            string message = car.ToString();

            while (true)
            {

                client.Connect(new IPEndPoint(IPAddress.Loopback, 7007));

                string input = Console.ReadLine();

                if (input != null)
                {
                    byte[] bytessent = Encoding.UTF8.GetBytes(input + message);

                    client.Send(bytessent, bytessent.Length);
                    Console.WriteLine("succesfully sent message:" + message);
                    client.Close();
                    Console.ReadLine();

                }

            }
        }
    }
}
