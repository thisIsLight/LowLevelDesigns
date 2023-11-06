using CacheStrategyLFULRU.CacheSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheStrategyLFULRU.CacheStrategy
{
    public interface ICacheStrategy
    {
        string GetItem(string key);
    }
}
