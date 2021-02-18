using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace task_01.Models
{
    public partial class ComputerStoreContext : DbContext
    {
        public ComputerStoreContext()
        {
        }

        public ComputerStoreContext(DbContextOptions<ComputerStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Manufacture> Manufactures { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= LAPTOP-R6T9OC7R\\SQLEXPRESS;Database=ComputerStore; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Manufacture>(entity =>
            {
                entity.HasKey(e => e.IdManufacture);

                entity.Property(e => e.IdManufacture)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Manufacture");

                entity.Property(e => e.NameManufacture)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Manufacture");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.Property(e => e.IdProduct)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Product");

                entity.Property(e => e.IdManufacture).HasColumnName("ID_Manufacture");

                entity.Property(e => e.NameProduct)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Product");

                entity.HasOne(d => d.IdManufactureNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdManufacture)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Manufacture_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
