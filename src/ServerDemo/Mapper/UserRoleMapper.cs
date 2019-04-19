using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface UserRoleMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(UserRole record);

        int insertSelective(UserRole record);

        UserRole selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(UserRole record);

        int updateByPrimaryKey(UserRole record);

        /// <summary>
        /// 通过用户ID和角色ID查询用户角色信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="roleId">角色ID</param>
        UserRole selectByUserIdRoleId(int userId, int roleId);

        /// <summary>
        /// 通过角色名查询用户角色信息
        /// </summary>
        /// <param name="roleName">角色名</param>
        UserRole selectByRoleName(string roleName);

        /// <summary>
        /// 通过用户ID查询用户角色信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        IList<UserRole> selectByUserId(int userId);
    }
}
