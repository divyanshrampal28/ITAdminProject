using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ITAdminProject.Models
{
    public partial class ItAdminContext : DbContext
    {
        public ItAdminContext()
        {
        }

        public ItAdminContext(DbContextOptions<ItAdminContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<StatusTable> StatusTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ItAdmin;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.CategoryName)
                    .HasName("UQ__Category__8517B2E084A8BDFE")
                    .IsUnique();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__RoleId__398D8EEE");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAtUtc)
                    .HasColumnName("UpdatedAtUTC")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasIndex(e => e.SerialNumber)
                    .HasName("UQ__Inventor__048A00082E05A097")
                    .IsUnique();

                entity.Property(e => e.CreatedAtUtc)
                    .HasColumnName("CreatedAtUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAtUtc)
                    .HasColumnName("UpdatedAtUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AssignedToNavigation)
                    .WithMany(p => p.InventoryAssignedToNavigation)
                    .HasForeignKey(d => d.AssignedTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Assig__45F365D3");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Categ__4316F928");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InventoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Creat__440B1D61");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Statu__46E78A0C");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.InventoryUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Updat__44FF419A");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusTable>(entity =>
            {
                entity.ToTable("Status_Table");

                entity.HasIndex(e => e.StatusName)
                    .HasName("UQ__Status_T__05E7698AD17008B1")
                    .IsUnique();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
