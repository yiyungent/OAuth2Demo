using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class SsoClientDetails
    {
        private int id;

        /**
         * 接入单点登录的系统名称
         */
        private string clientName;

        private string description;
        /**
         * 请求Token的回调URL
         */
        private string redirectUrl;
        /**
         * 注销URL
         */
        private string logoutUrl;

        private int status;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getClientName()
        {
            return clientName;
        }

        public void setClientName(string clientName)
        {
            this.clientName = clientName == null ? null : clientName.Trim();
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description == null ? null : description.Trim();
        }

        public string getRedirectUrl()
        {
            return redirectUrl;
        }

        public void setRedirectUrl(string redirectUrl)
        {
            this.redirectUrl = redirectUrl == null ? null : redirectUrl.Trim();
        }

        public string getLogoutUrl()
        {
            return logoutUrl;
        }

        public void setLogoutUrl(string logoutUrl)
        {
            this.logoutUrl = logoutUrl == null ? null : logoutUrl.Trim();
        }

        public int getStatus()
        {
            return status;
        }

        public void setStatus(int status)
        {
            this.status = status;
        }
    }
}