using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class UserRole
    {
        public UserRole()
        {
        }

        public UserRole(int userId, int roleId)
        {
            this.userId = userId;
            this.roleId = roleId;
        }

        private int id;

        private int userId;

        private int roleId;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getUserId()
        {
            return userId;
        }

        public void setUserId(int userId)
        {
            this.userId = userId;
        }

        public int getRoleId()
        {
            return roleId;
        }

        public void setRoleId(int roleId)
        {
            this.roleId = roleId;
        }
    }
}