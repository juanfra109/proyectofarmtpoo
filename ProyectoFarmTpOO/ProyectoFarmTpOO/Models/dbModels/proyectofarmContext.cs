using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoFarmTpOO.Models.dbModels
{
    public partial class proyectofarmContext : DbContext
    {
        public proyectofarmContext()
        {
        }

        public proyectofarmContext(DbContextOptions<proyectofarmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Almacen> Almacens { get; set; } = null!;
        public virtual DbSet<Carrito> Carritos { get; set; } = null!;
        public virtual DbSet<DetalleEv> DetalleEvs { get; set; } = null!;
        public virtual DbSet<Detalleap> Detalleaps { get; set; } = null!;
        public virtual DbSet<Detalleea> Detalleeas { get; set; } = null!;
        public virtual DbSet<Detalleev1> Detalleevs1 { get; set; } = null!;
        public virtual DbSet<Detallepp> Detallepps { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<Turno> Turnos { get; set; } = null!;
        public virtual DbSet<Ventum> Venta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=proyectofarm;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.HasKey(e => e.IdAlm)
                    .HasName("PK_almacen_Id_alm");
            });

            modelBuilder.Entity<Carrito>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpl, e.IdProd });

                entity.HasOne(d => d.IdEmplNavigation)
                    .WithMany(p => p.Carritos)
                    .HasForeignKey(d => d.IdEmpl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_carrito_empleado");

                entity.HasOne(d => d.IdProdNavigation)
                    .WithMany(p => p.Carritos)
                    .HasForeignKey(d => d.IdProd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_carrito_productos");
            });

            modelBuilder.Entity<DetalleEv>(entity =>
            {
                entity.HasKey(e => e.IdVent)
                    .HasName("PK_detalle_ev_id_vent");

                entity.Property(e => e.IdVent).ValueGeneratedNever();

                entity.HasOne(d => d.IdVentNavigation)
                    .WithOne(p => p.DetalleEv)
                    .HasForeignKey<DetalleEv>(d => d.IdVent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalle_ev_venta");

                entity.HasOne(d => d.TurnEmplNavigation)
                    .WithMany(p => p.DetalleEvs)
                    .HasForeignKey(d => d.TurnEmpl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalle_ev_empleado");
            });

            modelBuilder.Entity<Detalleap>(entity =>
            {
                entity.HasKey(e => e.IdDetalleap)
                    .HasName("PK_detalleap_Id_detalleap");

                entity.HasOne(d => d.IdAlmNavigation)
                    .WithMany(p => p.Detalleaps)
                    .HasForeignKey(d => d.IdAlm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalleap_almacen");
            });

            modelBuilder.Entity<Detalleea>(entity =>
            {
                entity.HasKey(e => e.IdDetalleEa)
                    .HasName("PK_detalleea_id_detalleEA");

                entity.HasOne(d => d.IdAlmNavigation)
                    .WithMany(p => p.Detalleeas)
                    .HasForeignKey(d => d.IdAlm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalleea_almacen");
            });

            modelBuilder.Entity<Detalleev1>(entity =>
            {
                entity.HasKey(e => e.IdDetalleEp)
                    .HasName("PK_detalleev_Id_detalleEP");

                entity.HasOne(d => d.IdEmplNavigation)
                    .WithMany(p => p.Detalleev1s)
                    .HasForeignKey(d => d.IdEmpl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalleev_empleado");

                entity.HasOne(d => d.IdProvNavigation)
                    .WithMany(p => p.Detalleev1s)
                    .HasForeignKey(d => d.IdProv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalleev_proveedor");
            });

            modelBuilder.Entity<Detallepp>(entity =>
            {
                entity.HasKey(e => e.IdDetallepp)
                    .HasName("PK_detallepp_id_detallepp");

                entity.HasOne(d => d.IdProdNavigation)
                    .WithMany(p => p.Detallepps)
                    .HasForeignKey(d => d.IdProd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detallepp_productos");

                entity.HasOne(d => d.IdProvNavigation)
                    .WithMany(p => p.Detallepps)
                    .HasForeignKey(d => d.IdProv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detallepp_proveedor");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpl)
                    .HasName("PK_empleado_Id_empl");

                entity.HasOne(d => d.TurnEmplNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.TurnEmpl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_empleado_turno");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProd)
                    .HasName("PK_productos_Id_prod");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProv)
                    .HasName("PK_proveedor_Id_prov");
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.HasKey(e => e.IdVent)
                    .HasName("PK_venta_Id_vent");

                entity.HasOne(d => d.IdEmplNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdEmpl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_venta_empleado");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
