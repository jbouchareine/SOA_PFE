using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using Newtonsoft.Json;
using CoreClasses;

namespace core_queue
{
    class receiver
    {
        public static void Receiver()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare("coreQueu", "fanout");

                    var queueName = channel.QueueDeclare().QueueName;

                    channel.QueueBind(queueName, "coreQueu", "");
                    var consumer = new QueueingBasicConsumer(channel);
                    channel.BasicConsume(queueName, true, consumer);

                    Console.WriteLine(" [*] Waiting for logs." +
                                      "To exit press CTRL+C");
                    while (true)
                    {
                        var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();

                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);

                        Console.WriteLine(" [x] {0}", message);

                        CoreObject item = CoreObject.ConverterJsonToObject(message);

                        if(item.TypeDestinataire == "Admin")
                        {
                            sender.Sender(message, "Admin");
                        }
                        else if(item.TypeDestinataire == "Truck")
                        {
                            sender.Sender(message, "Truck");
                        }
                    }
                }
            }
        }

       
    }
}
