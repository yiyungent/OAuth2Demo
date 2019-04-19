using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Service
{
    /// <summary>
    /// 授权相关Service
    /// </summary>
    public interface AuthorizationService
    {
        /// <summary>
        /// 注册需要接入的客户端信息
        /// </summary>
        /// <param name="authClientDetails">用户传递进来的关键信息</param>
        bool register(AuthClientDetails clientDetails);

        /// <summary>
        /// 通过id查询客户端信息
        /// </summary>
        AuthClientDetails selectClientDetailsById(int id);

        /// <summary>
        /// 通过client_id查询客户端信息
        /// </summary>
        AuthClientDetails selectClientDetailsByClientId(string clientId);

        /// <summary>
        /// 通过Access Token查询记录
        /// </summary>
        AuthAccessToken selectByAccessToken(string accessToken);

        /// <summary>
        /// 通过主键查询记录
        /// </summary>
        AuthAccessToken selectByAccessId(int id);

        /// <summary>
        /// 通过Refresh Token查询记录
        /// </summary>
        AuthRefreshToken selectByRefreshToken(string refreshToken);

        /// <summary>
        /// 保存哪个用户授权哪个接入的客户端哪种访问范围的权限
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="clientIdStr">接入的客户端client_id</param>
        /// <param name="scopeStr">可被访问的用户的权限范围，比如：basic、super</param>
        bool saveAuthClientUser(int userId, string clientIdStr, string scopeStr);

        /// <summary>
        /// 根据clientId、scope以及当前时间戳生成AuthorizationCode（有效期为10分钟）
        /// </summary>
        /// <param name="clientIdStr">客户端ID</param>
        /// <param name="scopeStr">scope</param>
        /// <param name="user">用户信息</param>
        string createAuthorizationCode(string clientIdStr, string scopeStr, User user);

        /// <summary>
        /// 生成Access Token
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <param name="savedClientDetails">接入的客户端信息</param>
        /// <param name="grantType">授权方式</param>
        /// <param name="scope">允许访问的用户权限范围</param>
        /// <param name="expiresIn">过期时间</param>
        string createAccessToken(User user, AuthClientDetails savedClientDetails, string grantType, string scope, long expiresIn);

        /// <summary>
        /// 生成Refresh Token
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <param name="authAccessToken">生成的Access Token信息</param>
        string createRefreshToken(User user, AuthAccessToken authAccessToken);
    }
}