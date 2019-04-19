using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models.Bo
{
    /// <summary>
    /// 扩展角色类
    /// </summary>
    public class RoleBo : Role
    {
        private IList<Func> funcs;

        private IList<Func> Funcs
        {
            get { return funcs; }
            set { funcs = value; }
        }

        public override string ToString()
        {
            return "RoleBo{" +
                    "funcs=" + funcs +
                    '}';
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            if (!base.Equals(o)) return false;
            RoleBo roleBo = (RoleBo)o;
            return Object.Equals(funcs, roleBo.funcs);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}