using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategyLFULRU.CacheStrategy
{
    public class LFUCacheDataItem : ICacheDataItem
    {
        public string Data { get; set; }
        public int Frequency { get; set; }

        public LFUCacheDataItem(string data, int freq)
        {
            Data = data;
            Frequency = freq;
        }

        public LFUCacheDataItem()
        {
            
        }

        public void IncrementFrequency()
        {
            Frequency++;
        }

        public override string ToString()
        {
            return Data;
        }
    }
}
