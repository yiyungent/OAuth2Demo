using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Utils
{
    /// <summary>
    /// JSON相关公共方法（通过 Newtonsoft.Json 实现）
    /// </summary>
    public class JsonUtils
    {
        /// <summary>
        /// 将对象转化为json字符串
        /// </summary>
        /// <param name="source">对象</param>
        public static string ToJson(object source)
        {
            return JsonConvert.SerializeObject(source);
        }

        /// <summary>
        /// 将json字符串还原为目标对象
        /// </summary>
        /// <param name="source">json字符串</param>
        public static T FromJson<T>(string source)
        {
            return JsonConvert.DeserializeObject<T>(source);
        }
    }
}