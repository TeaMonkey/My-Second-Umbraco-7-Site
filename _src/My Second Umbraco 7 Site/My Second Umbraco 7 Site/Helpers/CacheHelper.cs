using System;
using System.Runtime.Caching;

namespace My_Second_Umbraco_7_Site
{
    public static class Helper
    {
        public static T GetObjectFromCache<T>(string cacheObjectName, int cacheTimeInMinutes, Func<T> generateObject)
        {
            ObjectCache cache = MemoryCache.Default;
            var cachedObject = (T)cache[cacheObjectName];

            if (cachedObject == null)
            {
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(cacheTimeInMinutes);
                cachedObject = generateObject();
                cache.Set(cacheObjectName, cachedObject, policy);
            }

            return cachedObject;
        }
    }
}