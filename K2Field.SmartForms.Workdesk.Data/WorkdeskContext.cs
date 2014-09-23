using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Field.SmartForms.Workdesk.Data
{
    public class WorkdeskContext : DbContext
    {
        public WorkdeskContext()
            : base("WorkdeskContext")
        {
        }

        public DbSet<K2Field.SmartForms.Workdesk.Model.Workdesk> Workspace { get; set; }
        public DbSet<K2Field.SmartForms.Workdesk.Model.WorkdeskTeam> Team { get; set; }
        public DbSet<K2Field.SmartForms.Workdesk.Model.WorkdeskLink> Link { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Workdesk>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Model.WorkdeskTeam>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Model.WorkdeskLink>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<Data.CaseUser>().Ignore(p => p.FullName);
            //modelBuilder.Entity<Data.CaseInstance>().Ignore(p => p.ExceedsExpected);

            // team - user m:m
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //base.OnModelCreating(modelBuilder);
        }

    }
}
