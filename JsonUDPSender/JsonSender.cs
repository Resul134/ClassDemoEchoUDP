using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Modellibrary;
using Newtonsoft.Json;

namespace JsonUDPSender
{
    public class JsonSender
    {

        private const int PORT = 1337;
        public void Start()
        {
            UdpClient client = new UdpClient();

            Car car = new Car("Tesla", "Red", "Ar62969");

            Console.WriteLine("Ready to send on port: " + PORT);
            Console.Write(">");

            string message = JsonConvert.SerializeObject(car);

            client.Connect(new IPEndPoint(IPAddress.Any, PORT));

            while (true)
            {

                


               
                  byte[] bytessent = Encoding.UTF8.GetBytes(message);

                  client.Send(bytessent, bytessent.Length);
                  Console.WriteLine("succesfully sent message:" + message);

                   
                  Console.ReadLine();

                

            }
        }
    }
}
