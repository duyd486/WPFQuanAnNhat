﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyWPFTest.Models;

namespace MyWPFTest.DBContext;

public partial class QuanannhatContext : DbContext
{
    public QuanannhatContext()
    {
    }

    public QuanannhatContext(DbContextOptions<QuanannhatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<Dishlist> Dishlists { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Information> Informations { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<IngredientBill> IngredientBills { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderBill> OrderBills { get; set; }

    public virtual DbSet<Rate> Rates { get; set; }

    public virtual DbSet<SalaryBill> SalaryBills { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Wishlist> Wishlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-0333H5R\\SQLEXPRESS;Initial Catalog=quanannhat;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__discount__3213E83F317D1AAF");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Dish).WithMany(p => p.Discounts).HasConstraintName("FK__discounts__dish___5070F446");
        });

        modelBuilder.Entity<Dish>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dishes__3213E83F5FE7CDF1");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Dishlist).WithMany(p => p.Dishes).HasConstraintName("FK__dishes__dishlist__5165187F");
        });

        modelBuilder.Entity<Dishlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dishlist__3213E83F2FF86CAB");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83FC0BABF76");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Information).WithMany(p => p.Employees).HasConstraintName("FK__employees__infor__52593CB8");
        });

        modelBuilder.Entity<Information>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__informat__3213E83F1B5107CE");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ingredie__3213E83F5A96AB67");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<IngredientBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ingredie__3213E83F2052307D");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Ingredient).WithMany(p => p.IngredientBills).HasConstraintName("FK__ingredien__ingre__534D60F1");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__orders__3213E83FCF28C74A");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Dish).WithMany(p => p.Orders).HasConstraintName("FK__orders__dish_id__5629CD9C");

            entity.HasOne(d => d.Table).WithMany(p => p.Orders).HasConstraintName("FK__orders__table_id__571DF1D5");

            entity.HasOne(d => d.User).WithMany(p => p.Orders).HasConstraintName("FK__orders__user_id__5812160E");
        });

        modelBuilder.Entity<OrderBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__order_bi__3213E83F9705665E");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Discount).WithMany(p => p.OrderBills).HasConstraintName("FK__order_bil__disco__5441852A");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderBills).HasConstraintName("FK__order_bil__order__5535A963");
        });

        modelBuilder.Entity<Rate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__rates__3213E83FE664D695");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.Rates).HasConstraintName("FK__rates__user_id__59063A47");
        });

        modelBuilder.Entity<SalaryBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__salary_b__3213E83FFA278D31");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.SalaryBills).HasConstraintName("FK__salary_bi__emplo__59FA5E80");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tables__3213E83F66664A82");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83FF8F5ED3D");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Information).WithMany(p => p.Users).HasConstraintName("FK__users__informati__5AEE82B9");
        });

        modelBuilder.Entity<Wishlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__wishlist__3213E83F3158324F");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Dish).WithMany(p => p.Wishlists).HasConstraintName("FK__wishlist__dish_i__5BE2A6F2");

            entity.HasOne(d => d.User).WithMany(p => p.Wishlists).HasConstraintName("FK__wishlist__user_i__5CD6CB2B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
