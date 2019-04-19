using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Service
{
    /// <summary>
    /// SSO单点登录相关Service
    /// </summary>
    public interface SsoService
    {
        /// <summary>
        /// 根据ID查询接入客户端
        /// </summary>
        SsoClientDetails selectByPrimaryKey(int id);

        /// <summary>
        /// 根据URL查询记录
        /// </summary>
        /// <param name="redirectUrl">回调URL</param>
        SsoClientDetails selectByRedirectUrl(string redirectUrl);

        /// <summary>
        /// 通过主键ID查询记录
        /// </summary>
        /// <param name="id">ID</param>
        SsoAccessToken selectByAccessId(int id);

        /// <summary>
        /// 通过Access Token查询记录
        /// </summary>
        /// <param name="accessToken">Access Token</param>
        SsoAccessToken selectByAccessToken(string accessToken);

        /// <summary>
        /// 通过tokenId查询记录
        /// </summary>
        /// <param name="tokenId">tokenId</param>
        SsoRefreshToken selectByTokenId(int tokenId);

        /// <summary>
        /// 通过Refresh Token查询记录
        /// </summary>
        /// <param name="refreshToken">Refresh Token</param>
        SsoRefreshToken selectByRefreshToken(string refreshToken);

        /// <summary>
        /// 生成Access Token
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <param name="expiresIn">过期时间</param>
        /// <param name="requestIP">用户请求的IP</param>
        /// <param name="ssoClientDetails">接入客户端详情</param>
        string createAccessToken(User user, long expiresIn, string requestIP, SsoClientDetails ssoClientDetails);

        /// <summary>
        /// 生成Refresh Token
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <param name="ssoAccessToken">生成的Access Token信息</param>
        string createRefreshToken(User user, SsoAccessToken ssoAccessToken);
    }
}