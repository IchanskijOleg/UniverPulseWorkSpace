namespace ConsoleApplication11entity2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BusesContext : DbContext
    {
        public BusesContext()
            : base("name=BusesContext")
        {
        }

        public virtual DbSet<buses> buses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<buses>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
