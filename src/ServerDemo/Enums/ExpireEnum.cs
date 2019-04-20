using JavaCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Enums
{
    /// <summary>
    /// 过期时间相关枚举
    /// </summary>
    public class ExpireEnum
    {
        /// <summary>
        /// Authorization Code的有效期为10分钟
        /// </summary>
        public static readonly Expire AUTHORIZATION_CODE = new Expire(10L, TimeUnit.MINUTES);

        /// <summary>
        /// Access Token的有效期为30天
        /// </summary>
        public static readonly Expire ACCESS_TOKEN = new Expire(30L, TimeUnit.DAYS);

        /// <summary>
        /// Refresh Token的有效期为365天
        /// </summary>
        public static readonly Expire REFRESH_TOKEN = new Expire(365L, TimeUnit.DAYS);
    }

    /// <summary>
    /// 过期时间类
    /// </summary>
    public class Expire
    {
        private long time;

        /// <summary>
        /// 过期时间
        /// </summary>
        public long Time { get { return time; } }

        private TimeUnit timeUnit;

        /// <summary>
        /// 时间单位
        /// </summary>
        public TimeUnit TimeUnit { get { return timeUnit; } }

        public TimeSpan TimeSpan
        {
            get
            {
                TimeSpan timeSpan = TimeSpan.Zero;
                switch (this.timeUnit)
                {
                    case TimeUnit.NANOSECONDS:
                        throw new NotImplementedException("暂不支持 NANOSECONDS");
                        break;
                    case TimeUnit.MICROSECONDS:
                        throw new NotImplementedException("暂不支持 MICROSECONDS");
                        break;
                    case TimeUnit.MILLISECONDS:
                        timeSpan = TimeSpan.FromMilliseconds(this.time);
                        break;
                    case TimeUnit.SECONDS:
                        timeSpan = TimeSpan.FromSeconds(this.time);
                        break;
                    case TimeUnit.MINUTES:
                        timeSpan = TimeSpan.FromMinutes(this.time);
                        break;
                    case TimeUnit.HOURS:
                        timeSpan = TimeSpan.FromHours(this.time);
                        break;
                    case TimeUnit.DAYS:
                        timeSpan = TimeSpan.FromDays(this.time);
                        break;
                    default:
                        throw new NotImplementedException("暂不支持 此 TimeUnit");
                        break;
                }

                return timeSpan;
            }
        }

        public Expire(long time, TimeUnit timeUnit)
        {
            this.time = time;
            this.timeUnit = timeUnit;
        }
    }
}