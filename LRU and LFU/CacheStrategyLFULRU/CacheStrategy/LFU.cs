using CacheStrategyLFULRU.CacheSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CacheStrategyLFULRU.CacheStrategy
{
    public class LFU : ICacheStrategy
    {
        public Dictionary<string, LinkedListNode<LFUCacheDataItem>> CacheHash { get; set; }
        public LinkedList<LFUCacheDataItem> CacheData { get; set; }

        public LFU()
        {
            CacheHash = new Dictionary<string, LinkedListNode<LFUCacheDataItem>>();
            CacheData = new LinkedList<LFUCacheDataItem>();
        }

        public string GetItem(string key)
        {
            var result = string.Empty;
            if (CacheHash.ContainsKey(key))
            {
                var node = CacheHash[key];
                if (node != null)
                {
                    node.Value.IncrementFrequency();
                    result = node.Value.Data;
                    ReArrange(key);
                }
            }
            else
            {
                var newNodeData = data.FirstOrDefault(x => x.Data.Equals(key));
                if (CacheHash.Count < 3)
                {
                    var addedNode = CacheData.AddLast(newNodeData);
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
            var curNode = CacheHash[data];
            var count = CacheData.Count;
            var needsswap = false;
            for(var i = 0; i < count; i++)
            {
                if(curNode.Previous != null && curNode.Value.Frequency > curNode.Previous.Value.Frequency)
                {
                    curNode = curNode.Previous;
                    needsswap = true;
                }
                else
                {
                    break;
                }
            }
            if(!needsswap)
            {
                return;
            }
            else
            {
                var newNode = new LinkedListNode<LFUCacheDataItem>(new LFUCacheDataItem(CacheHash[data].Value.Data, CacheHash[data].Value.Frequency));
                CacheData.Remove(CacheHash[data]);
                CacheHash[data] = newNode;
                CacheData.AddBefore(curNode, newNode);
            }
        }

        public void Swap(LFUCacheDataItem newNodeData, string key)
        {
            var removedKey = "";
            if(CacheHash.Count > 0 && CacheData.Count > 0)
            {
                removedKey = CacheData.Last().Data;
                CacheData.RemoveLast();
            }
            var node = CacheData.AddLast(newNodeData);
            if(string.IsNullOrEmpty(removedKey)) {
                CacheHash.Add(key, node);
            }
            else
            {
                CacheHash[removedKey] = node;
            }
        }


        #region Data Population

        public List<LFUCacheDataItem> data = new List<LFUCacheDataItem>() {
            new LFUCacheDataItem("First",1),
            new LFUCacheDataItem("Second",1),
            new LFUCacheDataItem("Third",1),
            new LFUCacheDataItem("Fourth",1),
            new LFUCacheDataItem("Fifth",1),
        };

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var item in data)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }

        #endregion
    }
}
