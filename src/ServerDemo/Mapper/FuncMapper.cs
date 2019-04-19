using ServerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDemo.Mapper
{
    public interface FuncMapper
    {
        int deleteByPrimaryKey(int id);

        int insert(Func record);

        int insertSelective(Func record);

        Func selectByPrimaryKey(int id);

        int updateByPrimaryKeySelective(Func record);

        int updateByPrimaryKey(Func record);
    }
}
