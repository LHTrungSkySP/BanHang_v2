using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public partial class BanHangContext : DbContext
{
    public BanHangContext()
    {
    }

    public BanHangContext(DbContextOptions<BanHangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attribute> Attributes { get; set; }

    public virtual DbSet<AttributeOption> AttributeOptions { get; set; }

    public virtual DbSet<AttributeOptionValue> AttributeOptionValues { get; set; }

    public virtual DbSet<AttributeValueDateTime> AttributeValueDateTimes { get; set; }

    public virtual DbSet<AttributeValueDecimal> AttributeValueDecimals { get; set; }

    public virtual DbSet<AttributeValueInt> AttributeValueInts { get; set; }

    public virtual DbSet<AttributeValueText> AttributeValueTexts { get; set; }

    public virtual DbSet<AttributeValueVarchar> AttributeValueVarchars { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductTranslation> ProductTranslations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=banhang.c9cgs6sosl5s.us-east-1.rds.amazonaws.com;Database=BanHang;User ID=admin;Password=Chunchun123;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attribute>(entity =>
        {
            entity.Property(e => e.BackendType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<AttributeOption>(entity =>
        {
            entity.HasOne(d => d.Attribute).WithMany(p => p.AttributeOptions)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("FK_AttributeOptions_Attributes");
        });

        modelBuilder.Entity<AttributeOptionValue>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(255);

            entity.HasOne(d => d.Option).WithMany(p => p.AttributeOptionValues)
                .HasForeignKey(d => d.OptionId)
                .HasConstraintName("FK_AttributeOptionValues_AttributeOptions");
        });

        modelBuilder.Entity<AttributeValueDateTime>(entity =>
        {
            entity.Property(e => e.LanguageId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value).HasColumnType("ntext");

            entity.HasOne(d => d.Attribute).WithMany(p => p.AttributeValueDateTimes)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("FK_AttributeValueDateTimes_Attributes");

            entity.HasOne(d => d.Product).WithMany(p => p.AttributeValueDateTimes)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_AttributeValueDateTimes_Products");
        });

        modelBuilder.Entity<AttributeValueDecimal>(entity =>
        {
            entity.Property(e => e.LanguageId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Attribute).WithMany(p => p.AttributeValueDecimals)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("FK_AttributeValueDecimals_Attributes");

            entity.HasOne(d => d.Product).WithMany(p => p.AttributeValueDecimals)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_AttributeValueDecimals_Products");
        });

        modelBuilder.Entity<AttributeValueInt>(entity =>
        {
            entity.Property(e => e.LanguageId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Attribute).WithMany(p => p.AttributeValueInts)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("FK_AttributeValueInts_Attributes");

            entity.HasOne(d => d.Product).WithMany(p => p.AttributeValueInts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_AttributeValueInts_Products");
        });

        modelBuilder.Entity<AttributeValueText>(entity =>
        {
            entity.ToTable("AttributeValueText");

            entity.Property(e => e.LanguageId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value).HasColumnType("ntext");

            entity.HasOne(d => d.Attribute).WithMany(p => p.AttributeValueTexts)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("FK_AttributeValueText_Attributes");

            entity.HasOne(d => d.Product).WithMany(p => p.AttributeValueTexts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_AttributeValueText_Products");
        });

        modelBuilder.Entity<AttributeValueVarchar>(entity =>
        {
            entity.Property(e => e.LanguageId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Attribute).WithMany(p => p.AttributeValueVarchars)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("FK_AttributeValueVarchars_Attributes");

            entity.HasOne(d => d.Product).WithMany(p => p.AttributeValueVarchars)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_AttributeValueVarchars_Products");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ObjectId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SeoAlias)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SeoDescription).HasMaxLength(255);
            entity.Property(e => e.SeoKeyword).HasMaxLength(255);
            entity.Property(e => e.SeoTitle).HasMaxLength(255);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CustomerAddress).HasMaxLength(255);
            entity.Property(e => e.CustomerEmail).HasMaxLength(255);
            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.CustomerNote).HasMaxLength(255);
            entity.Property(e => e.CustomerPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.OrderId });

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_Orders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderDetails_Products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.ObjectId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasMany(d => d.Categories).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductInCategory",
                    r => r.HasOne<Category>().WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductInCategories_Categories"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductInCategories_Products"),
                    j =>
                    {
                        j.HasKey("ProductId", "CategoryId");
                        j.ToTable("ProductInCategories");
                    });
        });

        modelBuilder.Entity<ProductTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.LanguageId });

            entity.Property(e => e.LanguageId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Content).HasColumnType("ntext");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.SeoAlias)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SeoDescription).HasMaxLength(255);
            entity.Property(e => e.SeoKeyword).HasMaxLength(255);
            entity.Property(e => e.SeoTitle).HasMaxLength(255);

            entity.HasOne(d => d.Language).WithMany(p => p.ProductTranslations)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTranslations_Languages");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductTranslations)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductTranslations_Products");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
