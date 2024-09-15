using InMemoryKafka.Consumers;
using InMemoryKafka.KafkaQueue;

namespace InMemoryKafka
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //Create a Queue
            var kafka = new Queues();

            //Create Topics
            kafka.CreateTopic("1d");
            kafka.CreateTopic("2d");

            //Create Consumers
            var printer = new PrinterConsumer();
            var fax = new FaxConsumer();

            //Subscribing Printer and Fax to first Topic
            kafka.SubscribeToTopic("1d", printer);
            kafka.SubscribeToTopic("1d", fax);

            //Subscribing only printer to second Topic
            kafka.SubscribeToTopic("2d", printer);

            //Publishing Messages to Topic 1 in a stream
            PublisherOne(kafka);

            //Publish another set of messages to Topic 2
            //PublisherTwo(kafka);

            Task.WaitAll();

        }

        public static async Task PublisherOne(Queues kafka)
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Published published : " + i);
                kafka.Publish("1d", i);
            }
        }

        public static async Task PublisherTwo(Queues kafka)
        {
            for (var i = 100; i < 110; i++)
            {
                kafka.Publish("2d", i);
            }
        }
    }
}
