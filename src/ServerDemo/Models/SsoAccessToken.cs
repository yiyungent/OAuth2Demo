using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class SsoAccessToken
    {
        private int id;

        private String accessToken;

        private int userId;

        private String userName;

        private String ip;

        private int clientId;
        /**
         * Token的使用渠道（比如APP1、APP2）
         */
        private String channel;

        private long expiresIn;

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

        public String getAccessToken()
        {
            return accessToken;
        }

        public void setAccessToken(String accessToken)
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

        public String getUserName()
        {
            return userName;
        }

        public void setUserName(String userName)
        {
            this.userName = userName == null ? null : userName.Trim();
        }

        public String getIp()
        {
            return ip;
        }

        public void setIp(String ip)
        {
            this.ip = ip == null ? null : ip.Trim();
        }

        public int getClientId()
        {
            return clientId;
        }

        public void setClientId(int clientId)
        {
            this.clientId = clientId;
        }

        public String getChannel()
        {
            return channel;
        }

        public void setChannel(String channel)
        {
            this.channel = channel == null ? null : channel.Trim();
        }

        public long getExpiresIn()
        {
            return expiresIn;
        }

        public void setExpiresIn(long expiresIn)
        {
            this.expiresIn = expiresIn;
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