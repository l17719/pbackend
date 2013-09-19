using System;
using Microsoft.Practices.ServiceLocation;

namespace AppFabricCachingCore
{
    public class Cache
    {
        private static readonly ICacheProvider CacheProvider;
        #region ctor
        static Cache()
        {
            CacheProvider = (ICacheProvider)ServiceLocator.Current.GetInstance(typeof(ICacheProvider));
        }
        #endregion

        #region Metodos
        public static void Add(string key, object value)
        {
            CacheProvider.Add(key, value);
        }
        public static void Add(string key, object value, TimeSpan valueTime)
        {
            CacheProvider.Add(key, value, valueTime);
        }

        public static object Get(string key)
        {
            return CacheProvider[key];
        }
        public static bool Remove(string key)
        {
            return CacheProvider.Remove(key);
        }
        #endregion
    }
}
