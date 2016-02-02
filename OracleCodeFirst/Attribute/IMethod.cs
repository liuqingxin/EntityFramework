using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleCodeFirst.Attribute
{
    public interface IMethod
    {
        void Create(string sql, DbContext context);
    }
}
