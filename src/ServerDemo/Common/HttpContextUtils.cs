using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace ServerDemo.Common
{
    public class HttpContextUtils
    {
        public static HttpRequest getRequest()
        {
            return HttpContext.Current.Request;
        }

        public static HttpSessionState getSession()
        {
            return HttpContext.Current.Session;
        }

        /// <summary>
        /// 获取完整的请求URL
        /// </summary>
        /// <returns></returns>
        public static string getRequestUrl()
        {
            return getRequestUrl(getRequest());
        }

        /// <summary>
        /// 获取完整的请求URL
        /// </summary>
        /// <returns></returns>
        public static string getRequestUrl(HttpRequest request)
        {
            return request.Url.AbsoluteUri;
        }

        /// <summary>
        /// 获取请求的客户端IP
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string getRequestIp(HttpRequest request)
        {
            string ip = null;
            try
            {
                ip = request.Headers["X-Forwarded-For"];
            }
            catch
            { }
            if (!string.IsNullOrEmpty(ip) && !"unKnown".Equals(ip, StringComparison.OrdinalIgnoreCase))
            {
                // 多次反向代理后会有多个ip值，第一个ip才是真实ip
                int index = ip.IndexOf(",");
                if (index != -1)
                {
                    return ip.Substring(0, index + 1);
                }
                else
                {
                    return ip;
                }
            }
            try
            {
                ip = request.Headers["X-Real-IP"];
                if (!string.IsNullOrEmpty(ip) && !"unKnown".Equals(ip, StringComparison.OrdinalIgnoreCase))
                {
                    return ip;
                }
            }
            catch
            { }

            return request.UserHostAddress;
        }
    }
}