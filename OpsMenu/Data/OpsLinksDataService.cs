using System.Collections.Generic;

namespace OpsMenu.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OpsLinksDataService : DbContext, IOpsDataService
    {
        public OpsLinksDataService()
            : base("name=OpsLinksDataService")
        {
            OpsApplicationLinks = OpsLinks;
        }

        public virtual DbSet<OpsLink> OpsLinks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OpsLink>()
                .Property(e => e.AppName)
                .IsUnicode(false);

            modelBuilder.Entity<OpsLink>()
                .Property(e => e.PathToApplication)
                .IsUnicode(false);

            modelBuilder.Entity<OpsLink>()
                .Property(e => e.GroupName)
                .IsUnicode(false);
        }

        #region Implementation of IOpsDataService

        public IEnumerable<IOpsData> OpsApplicationLinks { get; set; }

        #endregion
    }
}
