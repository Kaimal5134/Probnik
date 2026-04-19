using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace WinFormsApp2.Models;

public partial class DemDemContext : DbContext
{
    public DemDemContext()
    {
    }

    public DemDemContext(DbContextOptions<DemDemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ed> Eds { get; set; }

    public virtual DbSet<Manufact> Manufacts { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductTovarPhoto> ProductTovarPhotos { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Suplier> Supliers { get; set; }

    public virtual DbSet<TipeProduct> TipeProducts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=91.222.238.6;username=rover_user;password=root123;database=Dem_dem", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Ed>(entity =>
        {
            entity.HasKey(e => e.Ided).HasName("PRIMARY");

            entity.ToTable("ed");

            entity.Property(e => e.Ided).HasColumnName("ided");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Manufact>(entity =>
        {
            entity.HasKey(e => e.Idmanufact).HasName("PRIMARY");

            entity.ToTable("manufact");

            entity.Property(e => e.Idmanufact).HasColumnName("idmanufact");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Idzakaz).HasName("PRIMARY");

            entity.HasIndex(e => e.Fio, "fio_idx");

            entity.HasIndex(e => e.IdStatus, "id_status_idx");

            entity.Property(e => e.Idzakaz).HasColumnName("idzakaz");
            entity.Property(e => e.Adrec)
                .HasMaxLength(100)
                .HasColumnName("adrec");
            entity.Property(e => e.Article)
                .HasMaxLength(45)
                .HasColumnName("article");
            entity.Property(e => e.DataStart).HasColumnName("data_start");
            entity.Property(e => e.DateEnd).HasColumnName("date_end");
            entity.Property(e => e.Fio).HasColumnName("fio");
            entity.Property(e => e.IdStatus).HasColumnName("id_Status");

            entity.HasOne(d => d.FioNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Fio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("foi");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_status");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.IdorderItems).HasName("PRIMARY");

            entity.ToTable("order_items");

            entity.HasIndex(e => e.IdOrder, "id_order_idx");

            entity.HasIndex(e => e.IdProduct, "id_product_idx");

            entity.Property(e => e.IdorderItems).HasColumnName("idorder_items");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.KolVo).HasColumnName("kol-vo");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.IdOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_order");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_product");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Idproduct).HasName("PRIMARY");

            entity.ToTable("product");

            entity.HasIndex(e => e.IdEd, "id_ed_idx");

            entity.HasIndex(e => e.IdManufactur, "id_manufact_idx");

            entity.HasIndex(e => e.IdSuplier, "id_supplier_idx");

            entity.HasIndex(e => e.IdTipeProduct, "id_tipe_product_idx");

            entity.Property(e => e.Idproduct).HasColumnName("idproduct");
            entity.Property(e => e.Articl)
                .HasMaxLength(45)
                .HasColumnName("articl");
            entity.Property(e => e.IdEd).HasColumnName("id_ed");
            entity.Property(e => e.IdManufactur).HasColumnName("id_manufactur");
            entity.Property(e => e.IdPhoto).HasColumnName("id_photo");
            entity.Property(e => e.IdSuplier).HasColumnName("id_suplier");
            entity.Property(e => e.IdTipeProduct).HasColumnName("id_tipe_product");
            entity.Property(e => e.KolVo).HasColumnName("kol-vo");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PriceProduct)
                .HasPrecision(10, 2)
                .HasColumnName("price_product");
            entity.Property(e => e.ProductContent)
                .HasMaxLength(150)
                .HasColumnName("product_content");
            entity.Property(e => e.Sale).HasColumnName("sale");

            entity.HasOne(d => d.IdEdNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdEd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_ed");

            entity.HasOne(d => d.IdManufacturNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdManufactur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_manufact");

            entity.HasOne(d => d.IdSuplierNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdSuplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_supplier");

            entity.HasOne(d => d.IdTipeProductNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTipeProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_tipe_product");
        });

        modelBuilder.Entity<ProductTovarPhoto>(entity =>
        {
            entity.HasKey(e => e.IdproductTovarPhoto).HasName("PRIMARY");

            entity.ToTable("product_tovar_photo");

            entity.Property(e => e.IdproductTovarPhoto).HasColumnName("idproduct_tovar_photo");
            entity.Property(e => e.Photo).HasColumnName("photo");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("Role");

            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PRIMARY");

            entity.ToTable("Status");

            entity.Property(e => e.IdStatus).HasColumnName("idStatus");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Suplier>(entity =>
        {
            entity.HasKey(e => e.Idsuplier).HasName("PRIMARY");

            entity.ToTable("suplier");

            entity.Property(e => e.Idsuplier).HasColumnName("idsuplier");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TipeProduct>(entity =>
        {
            entity.HasKey(e => e.IdtipeProduct).HasName("PRIMARY");

            entity.ToTable("tipe_product");

            entity.Property(e => e.IdtipeProduct).HasColumnName("idtipe_product");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iduser).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.IdRole, "id_role_idx");

            entity.Property(e => e.Iduser).HasColumnName("iduser");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Fio)
                .HasMaxLength(45)
                .HasColumnName("fio");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Phone).HasColumnName("phone");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
