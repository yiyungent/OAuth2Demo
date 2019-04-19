using ServerDemo.Models;
using ServerDemo.Models.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerDemo.Service
{
    public interface UserService
    {
        /// <summary>
        /// 通过用户ID查询用户信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        User selectByUserId(int userId);

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user">用户详情</param>
        bool register(User user);

        /// <summary>
        /// 登录校验
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        IDictionary<string, object> checkLogin(string username, string password);

        /// <summary>
        /// 给用户添加角色信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="roleName">角色名</param>
        void addUserRole(int userId, string roleName);

        /// <summary>
        /// 通过scope查询不同程度的用户信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="scope">scope</param>
        User selectUserInfoByScope(int userId, string scope);

        /// <summary>
        /// 通过用户ID查询用户所属角色等信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        UserBo selectUserBoByUserId(int userId);
    }
}