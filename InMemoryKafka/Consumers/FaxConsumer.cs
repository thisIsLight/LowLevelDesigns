using InMemoryKafka.Interfaces;

namespace InMemoryKafka.Consumers
{
    public class FaxConsumer : IObservers
    {
        public string Name { get; set; } = "Fax";
        public void Consume(int data)
        {
            Console.WriteLine("Data is Faxed : " + data);
            Thread.Sleep(500);
        }
    }
}
