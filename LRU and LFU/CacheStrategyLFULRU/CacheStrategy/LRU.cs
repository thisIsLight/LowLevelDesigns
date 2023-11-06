using CacheStrategyLFULRU.CacheSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategyLFULRU.CacheStrategy
{
    public class LRU : ICacheStrategy
    {
        public Dictionary<string, LinkedListNode<LRUCacheDataItem>> CacheHash { get; set; }
        public LinkedList<LRUCacheDataItem> CacheData { get; set; }

        public LRU()
        {
            CacheHash = new Dictionary<string, LinkedListNode<LRUCacheDataItem>>();
            CacheData = new LinkedList<LRUCacheDataItem>();
        }
        public string GetItem(string key)
        {
        var result = string.Empty;
            if (CacheHash.ContainsKey(key))
            {
                var node = CacheHash[key];
                if (node != null)
                {
                    result = node.Value.Data;
                    ReArrange(key);
                }
            }
            else
            {
                var newNodeData = data.FirstOrDefault(x => x.Data.Equals(key));
                if (CacheHash.Count < 3)
                {
                    var addedNode = CacheData.AddFirst(newNodeData);
                    CacheHash.Add(key, addedNode);
                }
                else
                {
                    Swap(newNodeData, key);
                }
                result = newNodeData.Data;
            }
            return result;
        }

        public void ReArrange(string data)
        {
            if(CacheData.Count <= 1)
            {
                return;
            }
            else
            {
                var newNode = new LinkedListNode<LRUCacheDataItem>(new LRUCacheDataItem(data));
                CacheData.Remove(CacheHash[data]);
                CacheHash[data] = newNode;
                CacheData.AddFirst(newNode);
            }
        }

        public void Swap(LRUCacheDataItem newNodeData, string key)
        {
            var removedKey = "";
            if (CacheHash.Count > 0 && CacheData.Count > 0)
            {
                removedKey = CacheData.Last().Data;
                CacheData.RemoveLast();
            }
            var node = CacheData.AddFirst(newNodeData);
            if (string.IsNullOrEmpty(removedKey))
            {
                CacheHash.Add(key, node);
            }
            else
            {
                CacheHash[removedKey] = node;
            }
        }

        #region Data Population

        public List<LRUCacheDataItem> data = new List<LRUCacheDataItem>() {
            new LRUCacheDataItem("First"),
            new LRUCacheDataItem("Second"),
            new LRUCacheDataItem("Third"),
            new LRUCacheDataItem("Fourth"),
            new LRUCacheDataItem("Fifth"),
        };

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in data)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }

        #endregion
    }
}
