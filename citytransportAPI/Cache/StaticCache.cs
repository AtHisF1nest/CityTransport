using Core.Cache;

namespace citytransportAPI.Cache
{
    public class StaticCache : StaticCacheBase
    {

        public StaticCache()
        {
            //
        }

        // public CultureInfo CultureInfo
        // {
        //     get
        //     {
        //         return GetValueWithLock<CultureInfo>(StaticCacheKeys.CultureInfo, () =>
        //         {
        //             return CultureInfo.GetCultureInfo(_applicationOptions.ApplicationInfo.CultureInfo);
        //         });
        //     }
        // }

    }
}