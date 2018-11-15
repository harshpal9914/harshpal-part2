namespace WebApplication6.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Apple> Apples { get; set; }
        public virtual DbSet<Samsung> Samsungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apple>()
                .Property(e => e.Iphone1)
                .IsFixedLength();

            modelBuilder.Entity<Apple>()
                .Property(e => e.Iphone2)
                .IsFixedLength();

            modelBuilder.Entity<Apple>()
                .Property(e => e.Iphone3)
                .IsFixedLength();

            modelBuilder.Entity<Samsung>()
                .Property(e => e.Galaxy1)
                .IsFixedLength();

            modelBuilder.Entity<Samsung>()
                .Property(e => e.Galaxy2)
                .IsFixedLength();

            modelBuilder.Entity<Samsung>()
                .Property(e => e.Galaxy3)
                .IsFixedLength();
        }
    }
}
