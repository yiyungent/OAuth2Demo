using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface AuthRefreshTokenMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(AuthRefreshToken authRefreshToken);

        int insertSelective(AuthRefreshToken authRefreshToken);

        AuthRefreshToken selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(AuthRefreshToken authRefreshToken);

        int updateByPrimaryKey(AuthRefreshToken authRefreshToken);

        /// <summary>
        /// 通过tokenId查询记录
        /// </summary>
        /// <param name="tokenId">tokenId</param>
        AuthRefreshToken selectByTokenId(int tokenId);

        /// <summary>
        /// 通过Refresh Token查询记录
        /// </summary>
        /// <param name="refreshToken">Refresh Token</param>
        AuthRefreshToken selectByRefreshToken(string refreshToken);
    }
}
