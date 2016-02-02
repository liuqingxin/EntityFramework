
using OracleCodeFirst.Models;
using System;
using System.Data.Entity;
using System.Linq;
namespace OracleCodeFirst
{
    public class OracleContext : DbContext
    {
        public OracleContext() : base("name=DbContext")
        {

        }

        public DbSet<ViewTest> Test { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<OracleContext>(null); //禁止更新数据库架构
            /*
            Database.SetInitializer<OracleContext>(new OracleDatabaseInitializer()); 
            使用自定义方法更新数据库架构
            */
            
            modelBuilder.Entity<ViewTest>().ToTable("V_XSXXB", "CHG_SYYPT");
            base.OnModelCreating(modelBuilder);
        }
    }
}