using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface RoleMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(Role record);

        int insertSelective(Role record);

        Role selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(Role record);

        int updateByPrimaryKey(Role record);

        Role selectByRoleName(string roleName);
    }
}
