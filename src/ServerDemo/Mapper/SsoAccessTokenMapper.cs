using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface SsoAccessTokenMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(SsoAccessToken record);

        int insertSelective(SsoAccessToken record);

        SsoAccessToken selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(SsoAccessToken record);

        int updateByPrimaryKey(SsoAccessToken record);

        /// <summary>
        /// 通过用户ID查询记录
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="clientId">请求Token的渠道</param>
        SsoAccessToken selectByUserIdAndClientId(int userId, int clientId);

        /// <summary>
        /// 通过Access Token查询记录
        /// </summary>
        /// <param name="accessToken">Access Token</param>
        SsoAccessToken selectByAccessToken(string accessToken);
    }
}
