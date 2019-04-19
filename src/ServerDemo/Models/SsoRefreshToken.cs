using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class SsoRefreshToken
    {
        private int id;

        private int tokenId;

        private string refreshToken;

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

        public int getTokenId()
        {
            return tokenId;
        }

        public void setTokenId(int tokenId)
        {
            this.tokenId = tokenId;
        }

        public string getRefreshToken()
        {
            return refreshToken;
        }

        public void setRefreshToken(string refreshToken)
        {
            this.refreshToken = refreshToken == null ? null : refreshToken.Trim();
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