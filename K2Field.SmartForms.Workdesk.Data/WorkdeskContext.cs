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
            : base("WorkspaceContext")
        {
        }

        public DbSet<K2Field.SmartForms.Workdesk.Model.Workspace> Workspace { get; set; }
        public DbSet<K2Field.SmartForms.Workdesk.Model.WorkspaceTeam> Team { get; set; }
        public DbSet<K2Field.SmartForms.Workdesk.Model.WorkspaceLink> Link { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Workspace>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Model.WorkspaceTeam>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Model.WorkspaceLink>().Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<Data.CaseUser>().Ignore(p => p.FullName);
            //modelBuilder.Entity<Data.CaseInstance>().Ignore(p => p.ExceedsExpected);

            // team - user m:m
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //base.OnModelCreating(modelBuilder);
        }

    }
}
