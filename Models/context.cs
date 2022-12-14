using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FTSF8W_ZH.Models;

public partial class context : DbContext
{
    public context()
    {
    }

    public context(DbContextOptions<context> options)
        : base(options)
    {
    }

    public virtual DbSet<Ar> Ars { get; set; }

    public virtual DbSet<Borshop> Borshops { get; set; }

    public virtual DbSet<Evjarat> Evjarats { get; set; }

    public virtual DbSet<Vasarlo> Vasarlos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=zh3server.database.windows.net;Initial Catalog=ZH3Database;Persist Security Info=True;User ID=ftsf8w;Password=Anna02panna02");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ar>(entity =>
        {
            entity.ToTable("ar");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Borshop>(entity =>
        {
            entity.ToTable("borshop");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Arid).HasColumnName("arid");
            entity.Property(e => e.Evjaratid).HasColumnName("evjaratid");
            entity.Property(e => e.Marka)
                .HasMaxLength(50)
                .HasColumnName("marka");
            entity.Property(e => e.Tipus)
                .HasMaxLength(50)
                .HasColumnName("tipus");
            entity.Property(e => e.Vasarlasidopont)
                .HasColumnType("datetime")
                .HasColumnName("vasarlasidopont");
            entity.Property(e => e.Vasarloid).HasColumnName("vasarloid");

            entity.HasOne(d => d.Ar).WithMany(p => p.Borshops)
                .HasForeignKey(d => d.Arid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_borshop_ar");

            entity.HasOne(d => d.Evjarat).WithMany(p => p.Borshops)
                .HasForeignKey(d => d.Evjaratid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_borshop_evjarat");

            entity.HasOne(d => d.Vasarlo).WithMany(p => p.Borshops)
                .HasForeignKey(d => d.Vasarloid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_borshop_vasarlo");
        });

        modelBuilder.Entity<Evjarat>(entity =>
        {
            entity.ToTable("evjarat");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Ev).HasColumnName("ev");
        });

        modelBuilder.Entity<Vasarlo>(entity =>
        {
            entity.ToTable("vasarlo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nev)
                .HasMaxLength(50)
                .HasColumnName("nev");
            entity.Property(e => e.Varos)
                .HasMaxLength(50)
                .HasColumnName("varos");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
