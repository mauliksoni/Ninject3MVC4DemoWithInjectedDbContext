using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace NinjectMVC4Demo
{
    public class ApplicationLogMap : EntityTypeConfiguration<ApplicationLog>
    {
        public ApplicationLogMap()
        {
            //Primary Key
            this.HasKey(t => t.ApplicationLogId);

            // Properties
            this.Property(t => t.LogDate)
                .IsRequired();

            this.Property(t => t.Message)
                .IsMaxLength()
                .IsRequired();

            this.Property(t => t.LogLevel)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("ApplicationLog");
        }
    }
}