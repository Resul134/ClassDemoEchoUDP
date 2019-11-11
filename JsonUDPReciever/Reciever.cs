using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Modellibrary;
using Newtonsoft.Json;

namespace JsonUDPReciever
{
    public class Reciever
    {
        private const int PORT = 1337;

        public void Start()
        {
            UdpClient client = new UdpClient(PORT);

            Console.WriteLine("UDP receiver started på port" + PORT);

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, PORT);

            while (true)
            {
                byte[] bytes = client.Receive(ref endpoint);
                string str = Encoding.UTF8.GetString(bytes);

                Car car = JsonConvert.DeserializeObject<Car>(str);

                Console.WriteLine("Modtaget: " + car);
                string upperStr = str.ToUpper();


                byte[] buffer = Encoding.UTF8.GetBytes(upperStr.ToCharArray(), 0, upperStr.Length);


                client.Send(buffer, buffer.Length, endpoint);


            }
        }
    }
}
