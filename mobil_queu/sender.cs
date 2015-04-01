using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace core_queue
{
    class sender
    {
        public static void Sender(String message, string queu)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(queu, "fanout");

                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(queu, "", null, body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
        }
    }
}
