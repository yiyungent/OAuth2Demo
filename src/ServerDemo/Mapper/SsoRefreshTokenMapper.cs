using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface SsoRefreshTokenMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(SsoRefreshToken record);

        int insertSelective(SsoRefreshToken record);

        SsoRefreshToken selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(SsoRefreshToken record);

        int updateByPrimaryKey(SsoRefreshToken record);

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
    }
}
