﻿// <auto-generated />
using System;
using FarmaciaProyecto.Models.dbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FarmaciaProyecto.Migrations
{
    [DbContext(typeof(proyectofarmContext))]
    partial class proyectofarmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Almacen", b =>
                {
                    b.Property<int>("IdAlm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_alm");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAlm"), 1L, 1);

                    b.Property<string>("NomAlm")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("nom_alm");

                    b.HasKey("IdAlm")
                        .HasName("PK_almacen_Id_alm");

                    b.ToTable("almacen", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Carrito", b =>
                {
                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("id_empl");

                    b.Property<int>("IdProd")
                        .HasColumnType("int")
                        .HasColumnName("id_prod");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<decimal>("Total")
                        .HasColumnType("money")
                        .HasColumnName("total");

                    b.HasKey("IdEmpl", "IdProd");

                    b.HasIndex("IdProd");

                    b.ToTable("carrito");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Detalleap", b =>
                {
                    b.Property<int>("IdDetalleap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_detalleap");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleap"), 1L, 1);

                    b.Property<int>("IdAlm")
                        .HasColumnType("int")
                        .HasColumnName("Id_alm");

                    b.Property<int>("IdProd")
                        .HasColumnType("int")
                        .HasColumnName("id_prod");

                    b.HasKey("IdDetalleap")
                        .HasName("PK_detalleap_Id_detalleap");

                    b.HasIndex("IdAlm");

                    b.ToTable("detalleap", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Detalleea", b =>
                {
                    b.Property<int>("IdDetalleEa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_detalleEA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleEa"), 1L, 1);

                    b.Property<DateTime>("FechaDetalleEa")
                        .HasColumnType("date")
                        .HasColumnName("fecha_detalleEA");

                    b.Property<int>("IdAlm")
                        .HasColumnType("int")
                        .HasColumnName("id_alm");

                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("id_empl");

                    b.HasKey("IdDetalleEa")
                        .HasName("PK_detalleea_id_detalleEA");

                    b.HasIndex("IdAlm");

                    b.ToTable("detalleea", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.DetalleEv", b =>
                {
                    b.Property<int>("IdVent")
                        .HasColumnType("int")
                        .HasColumnName("id_vent");

                    b.Property<DateTime>("FechVent")
                        .HasColumnType("date")
                        .HasColumnName("fech_vent");

                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("id_empl");

                    b.Property<int>("TurnEmpl")
                        .HasColumnType("int")
                        .HasColumnName("turn_empl");

                    b.HasKey("IdVent")
                        .HasName("PK_detalle_ev_id_vent");

                    b.HasIndex("TurnEmpl");

                    b.ToTable("detalle_ev", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Detalleev1", b =>
                {
                    b.Property<int>("IdDetalleEp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_detalleEP");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleEp"), 1L, 1);

                    b.Property<DateTime>("FechDetalleEp")
                        .HasColumnType("date")
                        .HasColumnName("fech_detalleEP");

                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("Id_empl");

                    b.Property<int>("IdProv")
                        .HasColumnType("int")
                        .HasColumnName("Id_prov");

                    b.HasKey("IdDetalleEp")
                        .HasName("PK_detalleev_Id_detalleEP");

                    b.HasIndex("IdEmpl");

                    b.HasIndex("IdProv");

                    b.ToTable("detalleev", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Detallepp", b =>
                {
                    b.Property<int>("IdDetallepp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_detallepp");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetallepp"), 1L, 1);

                    b.Property<int>("CantProd")
                        .HasColumnType("int")
                        .HasColumnName("cant_prod");

                    b.Property<int>("IdProd")
                        .HasColumnType("int")
                        .HasColumnName("id_prod");

                    b.Property<int>("IdProv")
                        .HasColumnType("int")
                        .HasColumnName("id_prov");

                    b.Property<string>("NomProd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nom_prod");

                    b.HasKey("IdDetallepp")
                        .HasName("PK_detallepp_id_detallepp");

                    b.HasIndex("IdProd");

                    b.HasIndex("IdProv");

                    b.ToTable("detallepp", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Empleado", b =>
                {
                    b.Property<int>("IdEmpl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_empl");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpl"), 1L, 1);

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contraseña");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correo");

                    b.Property<string>("DirEmpl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("dir_empl");

                    b.Property<string>("NomEmpl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nom_empl");

                    b.Property<string>("RfcEmpl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("RFC_empl");

                    b.Property<string>("TelEmp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tel_emp");

                    b.Property<int>("TurnEmpl")
                        .HasColumnType("int")
                        .HasColumnName("turn_empl");

                    b.HasKey("IdEmpl")
                        .HasName("PK_empleado_Id_empl");

                    b.HasIndex("TurnEmpl");

                    b.ToTable("empleado", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Producto", b =>
                {
                    b.Property<int>("IdProd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_prod");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProd"), 1L, 1);

                    b.Property<int>("CantProd")
                        .HasColumnType("int")
                        .HasColumnName("cant_prod");

                    b.Property<string>("NomProd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nom_prod");

                    b.Property<int>("PrecProd")
                        .HasColumnType("int")
                        .HasColumnName("prec_prod");

                    b.HasKey("IdProd")
                        .HasName("PK_productos_Id_prod");

                    b.ToTable("productos", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Proveedor", b =>
                {
                    b.Property<int>("IdProv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_prov");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProv"), 1L, 1);

                    b.Property<string>("CorrProv")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("corr_prov");

                    b.Property<string>("DirProv")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("dir_prov");

                    b.Property<string>("NomProv")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("nom_prov");

                    b.Property<string>("TelProv")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("tel_prov");

                    b.HasKey("IdProv")
                        .HasName("PK_proveedor_Id_prov");

                    b.ToTable("proveedor", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Turno", b =>
                {
                    b.Property<int>("IdTurn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_turn");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTurn"), 1L, 1);

                    b.Property<string>("NombreTurn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombre_turn");

                    b.HasKey("IdTurn");

                    b.ToTable("turno");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Ventum", b =>
                {
                    b.Property<int>("IdVent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_vent");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVent"), 1L, 1);

                    b.Property<DateTime>("FechVent")
                        .HasColumnType("date")
                        .HasColumnName("Fech_vent");

                    b.Property<int>("IdEmpl")
                        .HasColumnType("int")
                        .HasColumnName("Id_empl");

                    b.Property<decimal>("TotalVent")
                        .HasColumnType("decimal(19,4)")
                        .HasColumnName("total_vent");

                    b.HasKey("IdVent")
                        .HasName("PK_venta_Id_vent");

                    b.HasIndex("IdEmpl");

                    b.ToTable("venta", "farmacia");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Carrito", b =>
                {
                    b.HasOne("FarmaciaProyecto.Models.dbModels.Empleado", "IdEmplNavigation")
                        .WithMany("Carritos")
                        .HasForeignKey("IdEmpl")
                        .IsRequired()
                        .HasConstraintName("FK_carrito_empleado");

                    b.HasOne("FarmaciaProyecto.Models.dbModels.Producto", "IdProdNavigation")
                        .WithMany("Carritos")
                        .HasForeignKey("IdProd")
                        .IsRequired()
                        .HasConstraintName("FK_carrito_productos");

                    b.Navigation("IdEmplNavigation");

                    b.Navigation("IdProdNavigation");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Detalleap", b =>
                {
                    b.HasOne("FarmaciaProyecto.Models.dbModels.Almacen", "IdAlmNavigation")
                        .WithMany("Detalleaps")
                        .HasForeignKey("IdAlm")
                        .IsRequired()
                        .HasConstraintName("FK_detalleap_almacen");

                    b.Navigation("IdAlmNavigation");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Detalleea", b =>
                {
                    b.HasOne("FarmaciaProyecto.Models.dbModels.Almacen", "IdAlmNavigation")
                        .WithMany("Detalleeas")
                        .HasForeignKey("IdAlm")
                        .IsRequired()
                        .HasConstraintName("FK_detalleea_almacen");

                    b.Navigation("IdAlmNavigation");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.DetalleEv", b =>
                {
                    b.HasOne("FarmaciaProyecto.Models.dbModels.Ventum", "IdVentNavigation")
                        .WithOne("DetalleEv")
                        .HasForeignKey("FarmaciaProyecto.Models.dbModels.DetalleEv", "IdVent")
                        .IsRequired()
                        .HasConstraintName("FK_detalle_ev_venta");

                    b.HasOne("FarmaciaProyecto.Models.dbModels.Turno", "TurnEmplNavigation")
                        .WithMany("DetalleEvs")
                        .HasForeignKey("TurnEmpl")
                        .IsRequired()
                        .HasConstraintName("FK_detalle_ev_empleado");

                    b.Navigation("IdVentNavigation");

                    b.Navigation("TurnEmplNavigation");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Detalleev1", b =>
                {
                    b.HasOne("FarmaciaProyecto.Models.dbModels.Empleado", "IdEmplNavigation")
                        .WithMany("Detalleev1s")
                        .HasForeignKey("IdEmpl")
                        .IsRequired()
                        .HasConstraintName("FK_detalleev_empleado");

                    b.HasOne("FarmaciaProyecto.Models.dbModels.Proveedor", "IdProvNavigation")
                        .WithMany("Detalleev1s")
                        .HasForeignKey("IdProv")
                        .IsRequired()
                        .HasConstraintName("FK_detalleev_proveedor");

                    b.Navigation("IdEmplNavigation");

                    b.Navigation("IdProvNavigation");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Detallepp", b =>
                {
                    b.HasOne("FarmaciaProyecto.Models.dbModels.Producto", "IdProdNavigation")
                        .WithMany("Detallepps")
                        .HasForeignKey("IdProd")
                        .IsRequired()
                        .HasConstraintName("FK_detallepp_productos");

                    b.HasOne("FarmaciaProyecto.Models.dbModels.Proveedor", "IdProvNavigation")
                        .WithMany("Detallepps")
                        .HasForeignKey("IdProv")
                        .IsRequired()
                        .HasConstraintName("FK_detallepp_proveedor");

                    b.Navigation("IdProdNavigation");

                    b.Navigation("IdProvNavigation");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Empleado", b =>
                {
                    b.HasOne("FarmaciaProyecto.Models.dbModels.Turno", "TurnEmplNavigation")
                        .WithMany("Empleados")
                        .HasForeignKey("TurnEmpl")
                        .IsRequired()
                        .HasConstraintName("FK_empleado_turno");

                    b.Navigation("TurnEmplNavigation");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Ventum", b =>
                {
                    b.HasOne("FarmaciaProyecto.Models.dbModels.Empleado", "IdEmplNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IdEmpl")
                        .IsRequired()
                        .HasConstraintName("FK_venta_empleado");

                    b.Navigation("IdEmplNavigation");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Almacen", b =>
                {
                    b.Navigation("Detalleaps");

                    b.Navigation("Detalleeas");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Empleado", b =>
                {
                    b.Navigation("Carritos");

                    b.Navigation("Detalleev1s");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Producto", b =>
                {
                    b.Navigation("Carritos");

                    b.Navigation("Detallepps");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Proveedor", b =>
                {
                    b.Navigation("Detalleev1s");

                    b.Navigation("Detallepps");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Turno", b =>
                {
                    b.Navigation("DetalleEvs");

                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("FarmaciaProyecto.Models.dbModels.Ventum", b =>
                {
                    b.Navigation("DetalleEv");
                });
#pragma warning restore 612, 618
        }
    }
}
