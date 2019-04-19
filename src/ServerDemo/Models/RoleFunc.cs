using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class RoleFunc
    {
        private int id;

        private int roleId;

        private int funcId;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getRoleId()
        {
            return roleId;
        }

        public void setRoleId(int roleId)
        {
            this.roleId = roleId;
        }

        public int getFuncId()
        {
            return funcId;
        }

        public void setFuncId(int funcId)
        {
            this.funcId = funcId;
        }
    }
}