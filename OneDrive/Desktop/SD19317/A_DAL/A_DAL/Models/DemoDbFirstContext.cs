using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Models;

public partial class DemoDbFirstContext : DbContext
{
    public DemoDbFirstContext()
    {
    }

    public DemoDbFirstContext(DbContextOptions<DemoDbFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Hdct> Hdcts { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DUYDUC;Database=Demo_DbFirst;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hdct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HDCT__3214EC27AD99BE86");

            entity.ToTable("HDCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Gia).HasColumnType("money");
            entity.Property(e => e.Idhd).HasColumnName("IDHD");
            entity.Property(e => e.Idsp).HasColumnName("IDSP");

            entity.HasOne(d => d.IdhdNavigation).WithMany(p => p.Hdcts)
                .HasForeignKey(d => d.Idhd)
                .HasConstraintName("FK_HDCT_HD");

            entity.HasOne(d => d.IdspNavigation).WithMany(p => p.Hdcts)
                .HasForeignKey(d => d.Idsp)
                .HasConstraintName("FK_HDCT_SP");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HoaDon__3214EC076A9FC776");

            entity.ToTable("HoaDon");

            entity.Property(e => e.Mota).HasMaxLength(1000);
            entity.Property(e => e.TongTien).HasColumnType("money");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SanPham__3214EC07D8E8E678");

            entity.ToTable("SanPham");

            entity.Property(e => e.Gia).HasColumnType("money");
            entity.Property(e => e.Mota).HasMaxLength(1000);
            entity.Property(e => e.Ten).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
