using ServerDemo.Models;
using ServerDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerDemo.Controllers
{
    /// <summary>
    /// 通过Access Token访问的API服务
    /// <para>访问用户信息</para>
    /// </summary>
    public class UsersController : Controller
    {
        private AuthorizationService authorizationService;

        public ActionResult GetInfo()
        {
            string accessToken = Request["access_token"];
            // 查询数据库中的Access Token
            AuthAccessToken authAccessToken

            return View();
        }
    }
}