using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class User
    {
        private int id;

        private string username;

        private string password;

        private string mobile;

        private string email;

        private DateTime createTime;

        private DateTime updateTime;

        private int status;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getUsername()
        {
            return username;
        }

        public void setUsername(string username)
        {
            this.username = username == null ? null : username.Trim();
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password == null ? null : password.Trim();
        }

        public string getMobile()
        {
            return mobile;
        }

        public void setMobile(string mobile)
        {
            this.mobile = mobile == null ? null : mobile.Trim();
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email == null ? null : email.Trim();
        }

        public DateTime getCreateTime()
        {
            return createTime;
        }

        public void setCreateTime(DateTime createTime)
        {
            this.createTime = createTime;
        }

        public DateTime getUpdateTime()
        {
            return updateTime;
        }

        public void setUpdateTime(DateTime updateTime)
        {
            this.updateTime = updateTime;
        }

        public int getStatus()
        {
            return status;
        }

        public void setStatus(int status)
        {
            this.status = status;
        }

        public override string ToString()
        {
            return "User{" +
                    "id=" + id +
                    ", username='" + username + '\'' +
                    ", password='" + password + '\'' +
                    ", mobile='" + mobile + '\'' +
                    ", email='" + email + '\'' +
                    ", createTime=" + createTime +
                    ", updateTime=" + updateTime +
                    ", status=" + status +
                    '}';
        }
    }
}