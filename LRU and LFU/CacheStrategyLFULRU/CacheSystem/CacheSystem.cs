using CacheStrategyLFULRU.CacheStrategy;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategyLFULRU.CacheSystem
{
    public class CacheSystem
    {
        public ICacheStrategy CacheStrategy { get; set; }

        public CacheSystem(ICacheStrategy cacheStrategy)
        {
            CacheStrategy = cacheStrategy;
        }

        public string GetItem(string key)
        {
            return CacheStrategy.GetItem(key);
        }
    }
}
