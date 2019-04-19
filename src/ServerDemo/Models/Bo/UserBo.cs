using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models.Bo
{
    public class UserBo : User
    {
        private IList<RoleBo> roles;

        public IList<RoleBo> Roles
        {
            get { return roles; }
            set { roles = value; }
        }

        public override string ToString()
        {
            return "UserBo{" +
                    "roles=" + roles +
                    '}';
        }
    }
}