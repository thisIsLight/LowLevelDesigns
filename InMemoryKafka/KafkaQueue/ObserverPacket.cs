using InMemoryKafka.Interfaces;
using System;
namespace InMemoryKafka.KafkaQueue
{
    public class ObserverPacket
    {
        public IObservers Observer { get; set; }
        public Topic Topic { get; set; }
        public int Offset { get; set; }
        public Thread Worker { get; set; }

        public ManualResetEvent WorkerToken = new ManualResetEvent(false);

        public ObserverPacket(IObservers observer, Topic topic)
        {
            Observer = observer;
            Offset = 0;
            Topic = topic;
            var threadDelegate = new ThreadStart(PublishToWorker);
            Worker = new Thread(threadDelegate);
            Worker.Start();
        }

        public void PublishToWorker()
        {
            while (true) {
                while (Offset >= Topic.Messages.Count)
                {
                    WorkerToken.WaitOne();
                }
                Observer.Consume(Topic.Messages.ElementAt(Offset));
                Offset++;
            }
        }
    }
}
