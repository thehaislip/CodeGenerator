namespace CodeGenerator
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Database> Databases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Database>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Database>()
                .Property(e => e.ConnectionString)
                .IsUnicode(false);

            modelBuilder.Entity<Database>()
                .Property(e => e.Namespace)
                .IsUnicode(false);
        }
    }
}
