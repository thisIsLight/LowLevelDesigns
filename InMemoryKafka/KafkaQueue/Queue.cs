using InMemoryKafka.Interfaces;

namespace InMemoryKafka.KafkaQueue
{
    public class Queues
    {
        public Dictionary<string, Topic> TopicsDictionary { get; set; }

        public Queues()
        {
            TopicsDictionary = new Dictionary<string, Topic>();
        }

        public void CreateTopic(string topicName)
        {
            TopicsDictionary.TryAdd(topicName, new Topic(topicName));
        }

        public void Publish(string topicName, int message)
        {
            TopicsDictionary.TryGetValue(topicName, out var topicToPublishTo);
            if (topicToPublishTo == null)
            {
                return;
            }
            topicToPublishTo.AddMessage(message);
        }

        public void SubscribeToTopic(string topicName, IObservers observer)
        {
            TopicsDictionary.TryGetValue(topicName, out var topicToPublishTo);
            if (topicToPublishTo == null)
            {
                return;
            }
            topicToPublishTo.Subscribe(observer);
        }

    }
}
