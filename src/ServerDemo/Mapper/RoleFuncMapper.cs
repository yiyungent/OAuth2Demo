using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface RoleFuncMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(RoleFunc record);

        int insertSelective(RoleFunc record);

        RoleFunc selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(RoleFunc record);

        int updateByPrimaryKey(RoleFunc record);
    }
}
