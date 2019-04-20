using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using ServerDemo.Common;
using ServerDemo.Mapper;
using ServerDemo.Models;
using ServerDemo.Utils;

namespace ServerDemo.Service.Impl
{
    public class AuthorizationServiceImpl : AuthorizationService
    {
        private RedisService redisService;

        private AuthClientDetailsMapper authClientDetailsMapper;

        private AuthScopeMapper authScopeMapper;

        private AuthClientUserMapper authClientUserMapper;

        private AuthAccessTokenMapper authAccessTokenMapper;

        private AuthRefreshTokenMapper authRefreshTokenMapper;

        public bool register(AuthClientDetails clientDetails)
        {
            // 客户端的名称和回调地址不能为空
            if (!string.IsNullOrEmpty(clientDetails.getClientName()) && !string.IsNullOrEmpty(clientDetails.getRedirectUri()))
            {
                // 生成24位随机的clientId
                string clientId = EncryptUtils.getRandomStr1(24);

                AuthClientDetails savedClientDetails = authClientDetailsMapper.selectByClientId(clientId);
                //生成的clientId必须是唯一的
                for (int i = 0; i < 10; i++)
                {
                    if (savedClientDetails == null)
                    {
                        break;
                    }
                    else
                    {
                        clientId = EncryptUtils.getRandomStr1(24);
                        savedClientDetails = authClientDetailsMapper.selectByClientId(clientId);
                    }
                }

                // 生成32位随机的clientSecret
                string clientSecret = EncryptUtils.getRandomStr1(32);

                DateTime current = new DateTime();
                HttpSessionState session = HttpContextUtils.getSession();
                User user = (User)session[Constants.SESSION_USER];


                // continuing...
            }


        }

















        public string createAccessToken(User user, AuthClientDetails savedClientDetails, string grantType, string scope, long expiresIn)
        {
            throw new NotImplementedException();
        }

        public string createAuthorizationCode(string clientIdStr, string scopeStr, User user)
        {
            throw new NotImplementedException();
        }

        public string createRefreshToken(User user, AuthAccessToken authAccessToken)
        {
            throw new NotImplementedException();
        }



        public bool saveAuthClientUser(int userId, string clientIdStr, string scopeStr)
        {
            throw new NotImplementedException();
        }

        public AuthAccessToken selectByAccessId(int id)
        {
            throw new NotImplementedException();
        }

        public AuthAccessToken selectByAccessToken(string accessToken)
        {
            throw new NotImplementedException();
        }

        public AuthRefreshToken selectByRefreshToken(string refreshToken)
        {
            throw new NotImplementedException();
        }

        public AuthClientDetails selectClientDetailsByClientId(string clientId)
        {
            throw new NotImplementedException();
        }

        public AuthClientDetails selectClientDetailsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}