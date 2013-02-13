using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace NinjectMVC4Demo
{
    public class SqlDataContext : DbContext
    {
        static SqlDataContext()
        {
            Database.SetInitializer<SqlDataContext>(null);
        }

        public DbSet<ApplicationLog> ApplicationLog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApplicationLogMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}