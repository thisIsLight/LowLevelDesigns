namespace InMemoryKafka.Interfaces
{
    public interface IObservers 
    {
        string Name { get; set; }
        void Consume(int data);
    }
}
