using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Common
{
    /// <summary>
    /// 公共常量类
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// 用户信息在session中存储的变量名
        /// </summary>
        public const string SESSION_USER = "SESSION_USER";

        /// <summary>
        /// 登录页面的回调地址在session中存储的变量名
        /// </summary>
        public const string SESSION_LOGIN_REDIRECT_URL = "LOGIN_REDIRECT_URL";

        /// <summary>
        /// 授权页面的回调地址在session中存储的变量名
        /// </summary>
        public const string SESSION_AUTH_REDIRECT_URL = "SESSION_AUTH_REDIRECT_URL";
    }
}