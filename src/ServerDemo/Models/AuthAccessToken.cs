using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class AuthAccessToken
    {
        private int id;

        /**
         * Access Token
         */
        private string accessToken;

        /**
         * 关联的用户ID
         */
        private int userId;
        /**
         * 关联的用户名
         */
        private string userName;

        /**
         * 接入的客户端ID
         */
        private int clientId;

        /**
         * 过期时间戳
         */
        private long expiresIn;

        /**
         * 授权类型，比如：authorization_code
         */
        private string grantType;
        /**
         * 可被访问的用户的权限范围，比如：basic、super
         */
        private string scope;

        private int createUser;

        private DateTime createTime;

        private int updateUser;

        private DateTime updateTime;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getAccessToken()
        {
            return accessToken;
        }

        public void setAccessToken(string accessToken)
        {
            this.accessToken = accessToken == null ? null : accessToken.Trim();
        }

        public int getUserId()
        {
            return userId;
        }

        public void setUserId(int userId)
        {
            this.userId = userId;
        }

        public string getUserName()
        {
            return userName;
        }

        public void setUserName(string userName)
        {
            this.userName = userName == null ? null : userName.Trim();
        }

        public int getClientId()
        {
            return clientId;
        }

        public void setClientId(int clientId)
        {
            this.clientId = clientId;
        }

        public long getExpiresIn()
        {
            return expiresIn;
        }

        public void setExpiresIn(long expiresIn)
        {
            this.expiresIn = expiresIn;
        }

        public string getGrantType()
        {
            return grantType;
        }

        public void setGrantType(string grantType)
        {
            this.grantType = grantType == null ? null : grantType.Trim();
        }

        public string getScope()
        {
            return scope;
        }

        public void setScope(string scope)
        {
            this.scope = scope == null ? null : scope.Trim();
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
    }
}