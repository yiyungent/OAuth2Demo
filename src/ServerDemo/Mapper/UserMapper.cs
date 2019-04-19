using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface UserMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(User user);

        int insertSelective(User user);

        User selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(User user);

        int updateByPrimaryKey(User user);

        User selectByUsername(string username);
    }
}
