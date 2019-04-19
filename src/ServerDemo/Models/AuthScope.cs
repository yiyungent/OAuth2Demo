using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class AuthScope
    {
        private int id;
        /**
         * 可被访问的用户的权限范围，比如：basic、super
         */
        private string scopeName;

        private string description;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getScopeName()
        {
            return scopeName;
        }

        public void setScopeName(string scopeName)
        {
            this.scopeName = scopeName == null ? null : scopeName.Trim();
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description == null ? null : description.Trim();
        }
    }
}