using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class Role
    {
        private int id;

        private string roleName;

        private string description;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getRoleName()
        {
            return roleName;
        }

        public void setRoleName(string roleName)
        {
            this.roleName = roleName == null ? null : roleName.Trim();
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description == null ? null : description.Trim();
        }


        public override string ToString()
        {
            return "Role{" +
                    "id=" + id +
                    ", roleName='" + roleName + '\'' +
                    ", description='" + description + '\'' +
                    '}';
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            Role role = (Role)o;
            return Object.Equals(id, role.id) &&
                    Object.Equals(roleName, role.roleName) &&
                    Object.Equals(description, role.description);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}