using InMemoryKafka.Interfaces;

namespace InMemoryKafka.Consumers
{
    public class PrinterConsumer : IObservers
    {
        public string Name { get; set; } = "Printer";
        public void Consume(int data)
        {
            Console.WriteLine("Data is Printed : " + data);
        }
    }
}
