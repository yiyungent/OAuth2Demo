using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Enums
{
    /// <summary>
    /// 授权方式
    /// </summary>
    public class GrantTypeEnum
    {
        public static readonly GrantType AUTHORIZATION_CODE = new GrantType("authorization_code");
    }

    /// <summary>
    /// 授权方式
    /// </summary>
    public class GrantType
    {
        private string type;

        public string Type { get { return type; } }

        public GrantType(string type)
        {
            this.type = type;
        }
    }
}