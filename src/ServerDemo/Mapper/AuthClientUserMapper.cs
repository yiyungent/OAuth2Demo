using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface AuthClientUserMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(AuthClientUser record);

        int insertSelective(AuthClientUser record);

        AuthClientUser selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(AuthClientUser record);

        int updateByPrimaryKey(AuthClientUser record);

        /// <summary>
        /// 根据 clientId、userId、scopeId查询用户给某个接入客户端的授权信息
        /// </summary>
        /// <param name="clientId">接入的客户端ID</param>
        /// <param name="userId">用户ID</param>
        AuthClientUser selectByClientId(int clientId, int userId, int scopeId);
    }
}
