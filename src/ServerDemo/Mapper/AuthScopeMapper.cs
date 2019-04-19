using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface AuthScopeMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(AuthScope record);

        int insertSelective(AuthScope record);

        AuthScope selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(AuthScope record);

        int updateByPrimaryKey(AuthScope record);

        /// <summary>
        /// 通过scopeName查询
        /// </summary>
        /// <param name="scopeName">可被访问的用户的权限范围，比如：basic、super</param>
        AuthScope selectByScopeName(string scopeName);
    }
}
