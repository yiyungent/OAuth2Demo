using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Models
{
    public class AuthClientUser
    {
        private int id;

        private int authClientId;

        private int userId;

        private int authScopeId;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getAuthClientId()
        {
            return authClientId;
        }

        public void setAuthClientId(int authClientId)
        {
            this.authClientId = authClientId;
        }

        public int getUserId()
        {
            return userId;
        }

        public void setUserId(int userId)
        {
            this.userId = userId;
        }

        public int getAuthScopeId()
        {
            return authScopeId;
        }

        public void setAuthScopeId(int authScopeId)
        {
            this.authScopeId = authScopeId;
        }
    }
}