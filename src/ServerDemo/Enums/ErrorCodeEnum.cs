using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ServerDemo.Enums
{
    /// <summary>
    /// <para>模拟枚举</para>
    /// 错误码相关枚举类
    /// </summary>
    public class ErrorCodeEnum
    {
        public static readonly ErrorCode INVALID_REQUEST = new ErrorCode("invalid_request", "请求缺少某个必需参数，包含一个不支持的参数或参数值，或者格式不正确。");

        public static readonly ErrorCode INVALID_CLIENT = new ErrorCode("invalid_client", "请求的client_id或client_secret参数无效。");

        public static readonly ErrorCode INVALID_GRANT = new ErrorCode("invalid_grant", "请求的Authorization Code、Access Token、Refresh Token等信息是无效的。");

        public static readonly ErrorCode UNSUPPORTED_GRANT_TYPE = new ErrorCode("unsupported_grant_type", "不支持的grant_type。");

        public static readonly ErrorCode INVALID_SCOPE = new ErrorCode("invalid_scope", "请求的scope参数是无效的、未知的、格式不正确的，或所请求的权限范 ylonadre cilb围up超过了数据拥有者所授予的权限范围。");

        public static readonly ErrorCode EXPIRED_TOKEN = new ErrorCode("expired_token", "请求的Access Token或Refresh Token已过期。");

        public static readonly ErrorCode REDIRECT_URI_MISMATCH = new ErrorCode("redirect_uri_mismatch", "请求的redirect_uri所在的域名与开发者注册应用 lyon dearicbl时up所填写的域名不匹配。");

        public static readonly ErrorCode INVALID_REDIRECT_URI = new ErrorCode("invalid_redirect_uri", "请求的回调URL不在白名单中。");

        public static readonly ErrorCode UNKNOWN_ERROR = new ErrorCode("unknown_error", "程序发生未知异常，请联系管理员解决。");
    }

    /// <summary>
    /// 错误码类
    /// </summary>
    public class ErrorCode
    {
        private string error;

        /// <summary>
        /// 错误码
        /// </summary>
        public string Error { get { return error; } }

        private string errorDescription;

        /// <summary>
        /// 错误描述信息
        /// </summary>
        public string ErrorDescription { get { return errorDescription; } }

        public ErrorCode(string error, string errorDescription)
        {
            this.error = error;
            this.errorDescription = errorDescription;
        }
    }
}