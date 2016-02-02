using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleCodeFirst.Attribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class ViewAttribute : System.Attribute, IMethod
    {
        public void Create(string sql, DbContext context)
        {
            context.Database.ExecuteSqlCommand(sql);
        }
    }
}
