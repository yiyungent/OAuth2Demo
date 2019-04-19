using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface AuthAccessTokenMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(AuthAccessToken authAccessToken);

        int insertSelective(AuthAccessToken authAccessToken);

        AuthAccessToken selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(AuthAccessToken authAccessToken);

        int updateByPrimaryKey(AuthAccessToken authAccessToken);

        /// <summary>
        /// 通过userId + clientId + scope查询记录
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="clientId">接入的客户端ID</param>
        /// <param name="scope">scope</param>
        AuthAccessToken selectByUserIdClientIdScope(int userId, int clientId, string scope);

        /// <summary>
        /// 通过Access Token查询记录
        /// </summary>
        /// <param name="accessToken">Access Token</param>
        AuthAccessToken selectByAccessToken(string accessToken);
    }
}
