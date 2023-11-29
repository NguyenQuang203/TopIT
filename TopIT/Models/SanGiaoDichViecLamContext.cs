using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TopIT.Models
{
    public partial class SanGiaoDichViecLamContext : DbContext
    {
        public SanGiaoDichViecLamContext()
        {
        }

        public SanGiaoDichViecLamContext(DbContextOptions<SanGiaoDichViecLamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCvDangki> TblCvDangkis { get; set; } = null!;
        public virtual DbSet<TblCvLuu> TblCvLuus { get; set; } = null!;
        public virtual DbSet<TblDoanhnghiep> TblDoanhnghieps { get; set; } = null!;
        public virtual DbSet<TblTaikhoan> TblTaikhoans { get; set; } = null!;
        public virtual DbSet<TblTinnhan> TblTinnhans { get; set; } = null!;
        public virtual DbSet<TblUngvien> TblUngviens { get; set; } = null!;
        public virtual DbSet<TblVieclam> TblVieclams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-ETMJ2PC6\\SQLEXPRESS;Initial Catalog=SanGiaoDichViecLam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCvDangki>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_CV_dangki");

                entity.Property(e => e.DNgayDk)
                    .HasColumnType("date")
                    .HasColumnName("dNgayDK");

                entity.Property(e => e.PkFkSMaUv)
                    .HasMaxLength(10)
                    .HasColumnName("PK_FK_sMaUV")
                    .IsFixedLength();

                entity.Property(e => e.PkFkSMavielam)
                    .HasMaxLength(10)
                    .HasColumnName("PK_FK_sMavielam")
                    .IsFixedLength();

                entity.Property(e => e.SKetqua)
                    .HasMaxLength(10)
                    .HasColumnName("sKetqua")
                    .IsFixedLength();

                entity.Property(e => e.SNhanxet)
                    .HasMaxLength(50)
                    .HasColumnName("sNhanxet");

                entity.HasOne(d => d.PkFkSMaUvNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PkFkSMaUv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CV_dangki_tbl_Ungvien");

                entity.HasOne(d => d.PkFkSMavielamNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PkFkSMavielam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CV_dangki_tbl_Vieclam");
            });

            modelBuilder.Entity<TblCvLuu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_CV_luu");

                entity.Property(e => e.PkFkSMaUv)
                    .HasMaxLength(10)
                    .HasColumnName("PK_FK_sMaUV")
                    .IsFixedLength();

                entity.Property(e => e.PkFkSMavieclam)
                    .HasMaxLength(10)
                    .HasColumnName("PK_FK_sMavieclam")
                    .IsFixedLength();

                entity.Property(e => e.STrangthai)
                    .HasMaxLength(10)
                    .HasColumnName("sTrangthai")
                    .IsFixedLength();

                entity.HasOne(d => d.PkFkSMaUvNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PkFkSMaUv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CV_luu_tbl_Ungvien");

                entity.HasOne(d => d.PkFkSMavieclamNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PkFkSMavieclam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CV_luu_tbl_Vieclam");
            });

            modelBuilder.Entity<TblDoanhnghiep>(entity =>
            {
                entity.HasKey(e => e.PkSMaDn);

                entity.ToTable("tbl_Doanhnghiep");

                entity.Property(e => e.PkSMaDn)
                    .HasMaxLength(10)
                    .HasColumnName("PK_sMaDN")
                    .IsFixedLength();

                entity.Property(e => e.SDiachi)
                    .HasMaxLength(50)
                    .HasColumnName("sDiachi");

                entity.Property(e => e.SEmail)
                    .HasMaxLength(30)
                    .HasColumnName("sEmail")
                    .IsFixedLength();

                entity.Property(e => e.SGioithieu).HasColumnName("sGioithieu");

                entity.Property(e => e.SSdt)
                    .HasMaxLength(10)
                    .HasColumnName("sSDT")
                    .IsFixedLength();

                entity.Property(e => e.STenDn)
                    .HasMaxLength(30)
                    .HasColumnName("sTenDN");

                entity.Property(e => e.SUrlDn)
                    .HasMaxLength(50)
                    .HasColumnName("sURL_DN")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblTaikhoan>(entity =>
            {
                entity.HasKey(e => e.PkMaNd);

                entity.ToTable("tbl_Taikhoan");

                entity.Property(e => e.PkMaNd)
                    .HasMaxLength(10)
                    .HasColumnName("PK_MaND")
                    .IsFixedLength();

                entity.Property(e => e.SLoainguoidung)
                    .HasMaxLength(10)
                    .HasColumnName("sLoainguoidung")
                    .IsFixedLength();

                entity.Property(e => e.SPassword)
                    .HasMaxLength(15)
                    .HasColumnName("sPassword")
                    .IsFixedLength();

                entity.Property(e => e.STenTk)
                    .HasMaxLength(30)
                    .HasColumnName("sTenTK")
                    .IsFixedLength();

                entity.HasOne(d => d.PkMaNdNavigation)
                    .WithOne(p => p.TblTaikhoan)
                    .HasForeignKey<TblTaikhoan>(d => d.PkMaNd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Taikhoan_tbl_Doanhnghiep");

                entity.HasOne(d => d.PkMaNd1)
                    .WithOne(p => p.TblTaikhoan)
                    .HasForeignKey<TblTaikhoan>(d => d.PkMaNd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Taikhoan_tbl_Ungvien");
            });

            modelBuilder.Entity<TblTinnhan>(entity =>
            {
                entity.HasKey(e => e.PkSMatinnhan);

                entity.ToTable("tbl_Tinnhan");

                entity.Property(e => e.PkSMatinnhan)
                    .HasMaxLength(10)
                    .HasColumnName("PK_sMatinnhan")
                    .IsFixedLength();

                entity.Property(e => e.DThoigiangui)
                    .HasColumnType("datetime")
                    .HasColumnName("dThoigiangui");

                entity.Property(e => e.FkSMaDn)
                    .HasMaxLength(10)
                    .HasColumnName("FK_sMaDN")
                    .IsFixedLength();

                entity.Property(e => e.FkSMaUv)
                    .HasMaxLength(10)
                    .HasColumnName("FK_sMaUV")
                    .IsFixedLength();

                entity.Property(e => e.SNoidung).HasColumnName("sNoidung");

                entity.HasOne(d => d.FkSMaDnNavigation)
                    .WithMany(p => p.TblTinnhans)
                    .HasForeignKey(d => d.FkSMaDn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Tinnhan_tbl_Doanhnghiep");

                entity.HasOne(d => d.FkSMaUvNavigation)
                    .WithMany(p => p.TblTinnhans)
                    .HasForeignKey(d => d.FkSMaUv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Tinnhan_tbl_Ungvien");
            });

            modelBuilder.Entity<TblUngvien>(entity =>
            {
                entity.HasKey(e => e.PkSMaUv);

                entity.ToTable("tbl_Ungvien");

                entity.Property(e => e.PkSMaUv)
                    .HasMaxLength(10)
                    .HasColumnName("PK_sMaUV")
                    .IsFixedLength();

                entity.Property(e => e.DNgaysinh)
                    .HasColumnType("date")
                    .HasColumnName("dNgaysinh");

                entity.Property(e => e.SDiachi)
                    .HasMaxLength(50)
                    .HasColumnName("sDiachi");

                entity.Property(e => e.SEmail)
                    .HasMaxLength(30)
                    .HasColumnName("sEmail")
                    .IsFixedLength();

                entity.Property(e => e.SGioitinh)
                    .HasMaxLength(3)
                    .HasColumnName("sGioitinh")
                    .IsFixedLength();

                entity.Property(e => e.SKinhnghiem)
                    .HasMaxLength(10)
                    .HasColumnName("sKinhnghiem")
                    .IsFixedLength();

                entity.Property(e => e.SSdt)
                    .HasMaxLength(10)
                    .HasColumnName("sSDT")
                    .IsFixedLength();

                entity.Property(e => e.STenUv)
                    .HasMaxLength(30)
                    .HasColumnName("sTenUV");

                entity.Property(e => e.SUrlCv)
                    .HasMaxLength(50)
                    .HasColumnName("sURL_CV")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblVieclam>(entity =>
            {
                entity.HasKey(e => e.PkSMavieclam);

                entity.ToTable("tbl_Vieclam");

                entity.Property(e => e.PkSMavieclam)
                    .HasMaxLength(10)
                    .HasColumnName("PK_sMavieclam")
                    .IsFixedLength();

                entity.Property(e => e.DNgaydang)
                    .HasColumnType("date")
                    .HasColumnName("dNgaydang");

                entity.Property(e => e.DNgayketthuc)
                    .HasColumnType("date")
                    .HasColumnName("dNgayketthuc");

                entity.Property(e => e.FkSMaDn)
                    .HasMaxLength(10)
                    .HasColumnName("FK_sMaDN")
                    .IsFixedLength();

                entity.Property(e => e.SHocvan)
                    .HasMaxLength(50)
                    .HasColumnName("sHocvan");

                entity.Property(e => e.SKinhnghiem)
                    .HasMaxLength(10)
                    .HasColumnName("sKinhnghiem")
                    .IsFixedLength();

                entity.Property(e => e.SMota).HasColumnName("sMota");

                entity.Property(e => e.SPhuongthuclam)
                    .HasMaxLength(50)
                    .HasColumnName("sPhuongthuclam");

                entity.Property(e => e.SVitriviec)
                    .HasMaxLength(50)
                    .HasColumnName("sVitriviec");

                entity.HasOne(d => d.FkSMaDnNavigation)
                    .WithMany(p => p.TblVieclams)
                    .HasForeignKey(d => d.FkSMaDn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Vieclam_tbl_Doanhnghiep");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
