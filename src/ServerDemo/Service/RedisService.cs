using JavaCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Service
{
    /// <summary>
    /// RedisService
    /// </summary>
    public interface RedisService
    {
        /// <summary>
        /// 向Redis中存储键值对
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void set(string key, object value);

        /// <summary>
        /// 向Redis中存储键值对，并设置过期时间
        /// </summary>
        /// <param name="key">KEY</param>
        /// <param name="value">VALUE</param>
        /// <param name="time">过期时间</param>
        /// <param name="timeUnit">时间单位</param>
        void setWithExpire(string key, object value, long time, TimeUnit timeUnit);

        /// <summary>
        /// 从Redis中获取键值对
        /// </summary>
        /// <param name="key">KEY</param>
        K Get<K>(string key);

        /// <summary>
        /// 删除Redis中的某个KEY
        /// </summary>
        /// <param name="key">KEY</param>
        bool delete(string key);
    }
}