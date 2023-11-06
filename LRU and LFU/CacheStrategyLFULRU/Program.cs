using CacheStrategyLFULRU.CacheStrategy;

namespace CacheStrategyLFULRU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cacheStrategy = new LFU();
            var cacheSystem = new CacheSystem.CacheSystem(cacheStrategy);

            //GetItem from LFU Cache
            var result1 = cacheSystem.GetItem("First");
            result1 = cacheSystem.GetItem("Second");
            result1 = cacheSystem.GetItem("Second");
            result1 = cacheSystem.GetItem("Second");
            result1 = cacheSystem.GetItem("Second");
            result1 = cacheSystem.GetItem("Second");
            result1 = cacheSystem.GetItem("Third");
            result1 = cacheSystem.GetItem("Third");
            result1 = cacheSystem.GetItem("Third");
            result1 = cacheSystem.GetItem("First");
            result1 = cacheSystem.GetItem("First");
            result1 = cacheSystem.GetItem("First");
            result1 = cacheSystem.GetItem("First");
            result1 = cacheSystem.GetItem("Fourth");

            //Get Item from LRU
            var LRUCache = new LRU();
            var lruCacheSystem = new CacheSystem.CacheSystem(LRUCache);

            //GetItem from LFU Cache
            result1 = lruCacheSystem.GetItem("First");
            result1 = lruCacheSystem.GetItem("Second");
            result1 = lruCacheSystem.GetItem("Second");
            result1 = lruCacheSystem.GetItem("Second");
            result1 = lruCacheSystem.GetItem("Second");
            result1 = lruCacheSystem.GetItem("Second");
            result1 = lruCacheSystem.GetItem("Third");
            result1 = lruCacheSystem.GetItem("Third");
            result1 = lruCacheSystem.GetItem("Third");
            result1 = lruCacheSystem.GetItem("First");
            result1 = lruCacheSystem.GetItem("First");
            result1 = lruCacheSystem.GetItem("First");
            result1 = lruCacheSystem.GetItem("First");
            result1 = lruCacheSystem.GetItem("Fourth");

        }
    }
}