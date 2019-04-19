using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface SsoClientDetailsMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(SsoClientDetails record);

        int insertSelective(SsoClientDetails record);

        SsoClientDetails selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(SsoClientDetails record);

        int updateByPrimaryKey(SsoClientDetails record);

        /// <summary>
        /// 根据URL查询记录
        /// </summary>
        /// <param name="redirectUrl">回调URL</param>
        SsoClientDetails selectByRedirectUrl(string redirectUrl);
    }
}
