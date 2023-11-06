using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategyLFULRU.CacheStrategy
{
    public class LRUCacheDataItem : ICacheDataItem
    {
        public string Data { get; set; }
        public LRUCacheDataItem(string data)
        {
            Data = data;
        }
    }
}
