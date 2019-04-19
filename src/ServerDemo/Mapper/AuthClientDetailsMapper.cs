using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface AuthClientDetailsMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(AuthClientDetails record);

        int insertSelective(AuthClientDetails record);

        AuthClientDetails selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(AuthClientDetails record);

        int updateByPrimaryKey(AuthClientDetails record);

        /// <summary>
        /// 通过clientId查询接入的客户端详情
        /// </summary>
        /// <param name="clientId">clientId</param>
        AuthClientDetails selectByClientId(string clientId);
    }
}
