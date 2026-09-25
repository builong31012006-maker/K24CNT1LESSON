using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BVLONGLesson10.Models;

public partial class BVLONGlesson10Context : DbContext
{
    public BVLONGlesson10Context()
    {
    }

    public BVLONGlesson10Context(DbContextOptions<BVLONGlesson10Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Bvlong> Bvlongs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Khóa hoặc xóa đoạn cấu hình cứng chuỗi kết nối ở đây để dùng cấu hình từ appsettings.json
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bvlong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BVLONG__3214EC274A5FCCEB");

            entity.ToTable("BVLONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BvlongEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BVLONG_Email");
            entity.Property(e => e.BvlongFullName)
                .HasMaxLength(100)
                .HasColumnName("BVLONG_FullName");
            entity.Property(e => e.BvlongPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BVLONG_Password");
            entity.Property(e => e.BvlongPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BVLONG_Phone");
            entity.Property(e => e.BvlongStatus).HasColumnName("BVLONG_Status");
            entity.Property(e => e.BvlongUsername)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BVLONG_Username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}