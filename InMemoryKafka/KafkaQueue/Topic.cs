using InMemoryKafka.Interfaces;

namespace InMemoryKafka.KafkaQueue
{
    public class Topic
    {
        public List<ObserverPacket> ObserverPackets { get; set; }
        public string TopicName { get; set; }
        public List<int> Messages { get; set; }

        public Topic(string topicName)
        {
            ObserverPackets = new List<ObserverPacket>();
            TopicName = topicName;
            Messages = new List<int>();
        }

        public void Subscribe(IObservers observer)
        {
            var newObserverPacket = new ObserverPacket(observer, this);
            ObserverPackets.Add(newObserverPacket);
        }

        public void AddMessage(int data)
        {
            Messages.Add(data);
            foreach (var packet in ObserverPackets) {
                packet.WorkerToken.Set();
            }
        }

    }
}
