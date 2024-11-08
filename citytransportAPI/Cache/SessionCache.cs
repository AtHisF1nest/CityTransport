using citytransportAPI.Dtos;
using citytransportAPI.Structs;
using Core.Cache;
using Microsoft.AspNetCore.Http;

namespace citytransportAPI.Cache
{
    public class SessionCache : SessionCacheBase
    {
        #region Constructors

        /// <summary>
        /// Session cache ma służyć tylko do utrzymywania itemów, ma zawierać wyłącznie propertiesy, brak wykorzystania jakiegokolwiek service.
        /// </summary>
        /// <param name="session"></param>
        public SessionCache(IHttpContextAccessor context, RequestCache requestCache)
            : base(context.HttpContext.Session, requestCache)
        {
            //
        }

        #endregion

        public PlayerInfoDto PlayerInfo
        {
            get { return GetFromSession<PlayerInfoDto>(SessionCacheKeys.PlayerInfo); }
            set { Set(value, SessionCacheKeys.PlayerInfo); }
        }

        public int LastCityId
        {
            get { return GetFromSession<int>(SessionCacheKeys.LastCityId); }
            set { Set(value, SessionCacheKeys.LastCityId); }
        }

    }
}