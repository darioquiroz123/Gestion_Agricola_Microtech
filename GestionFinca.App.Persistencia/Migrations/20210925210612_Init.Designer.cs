﻿// <auto-generated />
using System;
using GestionFinca.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionFinca.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210925210612_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GestionFinca.App.Dominio.AgroQuimico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("CantidadInreso")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("IngredienteActivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<string>("Responsable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadMedida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agroquimicos");
                });

            modelBuilder.Entity("GestionFinca.App.Dominio.FertilizanteEnmienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("CantidadInreso")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroICA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<string>("Responsable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadMedida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FertilizantesEnmiendas");
                });

            modelBuilder.Entity("GestionFinca.App.Dominio.Finca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Lotes")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("inventarioId")
                        .HasColumnType("int");

                    b.Property<int?>("loteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("inventarioId");

                    b.HasIndex("loteId");

                    b.ToTable("Fincas");
                });

            modelBuilder.Entity("GestionFinca.App.Dominio.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Existencias")
                        .HasColumnType("real");

                    b.Property<int?>("agroquimicoId")
                        .HasColumnType("int");

                    b.Property<int?>("fertilizanteEnmiendaId")
                        .HasColumnType("int");

                    b.Property<int?>("materialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("agroquimicoId");

                    b.HasIndex("fertilizanteEnmiendaId");

                    b.HasIndex("materialId");

                    b.ToTable("Inventarios");
                });

            modelBuilder.Entity("GestionFinca.App.Dominio.Lote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CantidadPlantas")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("TipoCultivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("transaccionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("transaccionId");

                    b.ToTable("Lotes");
                });

            modelBuilder.Entity("GestionFinca.App.Dominio.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("CantidadInreso")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<string>("Responsable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadMedida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materiales");
                });

            modelBuilder.Entity("GestionFinca.App.Dominio.Transaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CantidadProduccion")
                        .HasColumnType("int");

                    b.Property<float>("PrecioVenta")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Transacciones");
                });

            modelBuilder.Entity("GestionFinca.App.Dominio.Finca", b =>
                {
                    b.HasOne("GestionFinca.App.Dominio.Inventario", "inventario")
                        .WithMany()
                        .HasForeignKey("inventarioId");

                    b.HasOne("GestionFinca.App.Dominio.Lote", "lote")
                        .WithMany()
                        .HasForeignKey("loteId");

                    b.Navigation("inventario");

                    b.Navigation("lote");
                });

            modelBuilder.Entity("GestionFinca.App.Dominio.Inventario", b =>
                {
                    b.HasOne("GestionFinca.App.Dominio.AgroQuimico", "agroquimico")
                        .WithMany()
                        .HasForeignKey("agroquimicoId");

                    b.HasOne("GestionFinca.App.Dominio.FertilizanteEnmienda", "fertilizanteEnmienda")
                        .WithMany()
                        .HasForeignKey("fertilizanteEnmiendaId");

                    b.HasOne("GestionFinca.App.Dominio.Material", "material")
                        .WithMany()
                        .HasForeignKey("materialId");

                    b.Navigation("agroquimico");

                    b.Navigation("fertilizanteEnmienda");

                    b.Navigation("material");
                });

            modelBuilder.Entity("GestionFinca.App.Dominio.Lote", b =>
                {
                    b.HasOne("GestionFinca.App.Dominio.Transaccion", "transaccion")
                        .WithMany()
                        .HasForeignKey("transaccionId");

                    b.Navigation("transaccion");
                });
#pragma warning restore 612, 618
        }
    }
}
