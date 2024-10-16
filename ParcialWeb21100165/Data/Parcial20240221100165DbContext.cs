using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ParcialWeb21100165.Data;

public partial class Parcial20240221100165DbContext : DbContext
{
    public Parcial20240221100165DbContext()
    {
    }

    public Parcial20240221100165DbContext(DbContextOptions<Parcial20240221100165DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Competency> Competency { get; set; }

    public virtual DbSet<JobOffer> JobOffer { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302422;Database=Parcial20240221100165DB;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Competency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Competen__3214EC0767481CD3");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<JobOffer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobOffer__3214EC07057A4A07");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(20);
            entity.Property(e => e.Salary).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
