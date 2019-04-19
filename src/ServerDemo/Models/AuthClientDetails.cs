using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class AuthClientDetails
    {
        private int id;

        /**
         * 接入的客户端ID
         */
        private String clientId;

        /**
         * 接入的客户端的名称
         */
        private String clientName;

        /**
         * 接入的客户端的密钥
         */
        private String clientSecret;

        /**
         * 回调地址
         */
        private String redirectUri;

        private String description;

        private int createUser;

        private DateTime createTime;

        private int updateUser;

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

        public String getClientId()
        {
            return clientId;
        }

        public void setClientId(String clientId)
        {
            this.clientId = clientId == null ? null : clientId.Trim();
        }

        public String getClientName()
        {
            return clientName;
        }

        public void setClientName(String clientName)
        {
            this.clientName = clientName == null ? null : clientName.Trim();
        }

        public String getClientSecret()
        {
            return clientSecret;
        }

        public void setClientSecret(String clientSecret)
        {
            this.clientSecret = clientSecret == null ? null : clientSecret.Trim();
        }

        public String getRedirectUri()
        {
            return redirectUri;
        }

        public void setRedirectUri(String redirectUri)
        {
            this.redirectUri = redirectUri == null ? null : redirectUri.Trim();
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description == null ? null : description.Trim();
        }

        public int getCreateUser()
        {
            return createUser;
        }

        public void setCreateUser(int createUser)
        {
            this.createUser = createUser;
        }

        public DateTime getCreateTime()
        {
            return createTime;
        }

        public void setCreateTime(DateTime createTime)
        {
            this.createTime = createTime;
        }

        public int getUpdateUser()
        {
            return updateUser;
        }

        public void setUpdateUser(int updateUser)
        {
            this.updateUser = updateUser;
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
    }
}