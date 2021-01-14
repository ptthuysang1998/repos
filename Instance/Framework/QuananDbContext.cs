namespace Instance.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuananDbContext : DbContext
    {
        public QuananDbContext()
            : base("name=QuananDbContext")
        {
        }

        public virtual DbSet<Monan> Monans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Monan>()
                .Property(e => e.IDMon)
                .IsUnicode(false);

            modelBuilder.Entity<Monan>()
                .Property(e => e.TenMon)
                .IsFixedLength();
        }
    }
}
