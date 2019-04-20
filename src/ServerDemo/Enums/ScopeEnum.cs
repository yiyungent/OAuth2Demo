using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Enums
{
    /// <summary>
    /// 权限范围
    /// </summary>
    public class ScopeEnum
    {
        public static readonly Scope BASIC = new Scope("basic", "基础权限");

        public static readonly Scope SUPER = new Scope("super", "所有权限");
    }

    /// <summary>
    /// 权限范围
    /// </summary>
    public class Scope
    {
        private string code;
        public string Code { get { return code; } set { code = value; } }

        private string description;
        public string Description { get { return description; } set { description = value; } }

        public Scope(string code, string description)
        {
            this.code = code;
            this.description = description;
        }
    }
}