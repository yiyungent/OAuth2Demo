using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class Func
    {
        private int id;

        private string name;

        private string description;

        private string code;

        private string url;

        private int status;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name == null ? null : name.Trim();
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description == null ? null : description.Trim();
        }

        public string getCode()
        {
            return code;
        }

        public void setCode(string code)
        {
            this.code = code == null ? null : code.Trim();
        }

        public string getUrl()
        {
            return url;
        }

        public void setUrl(string url)
        {
            this.url = url == null ? null : url.Trim();
        }

        public int getStatus()
        {
            return status;
        }

        public void setStatus(int status)
        {
            this.status = status;
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            Func func = (Func)o;
            return Object.Equals(id, func.id) &&
                    Object.Equals(name, func.name) &&
                    Object.Equals(description, func.description) &&
                    Object.Equals(code, func.code) &&
                    Object.Equals(url, func.url) &&
                    Object.Equals(status, func.status);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}