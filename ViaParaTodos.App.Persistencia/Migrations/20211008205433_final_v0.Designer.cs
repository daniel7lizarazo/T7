﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ViaParaTodos.App.Persistencia.AppRepositorios;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    [DbContext(typeof(AppRepositorios.AppContext))]
    [Migration("20211008205433_final_v0")]
    partial class final_v0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Accidente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccidenteAgentesTransitoId")
                        .HasColumnType("int");

                    b.Property<int?>("AgentesTransitoId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gravedad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgentesTransitoId");

                    b.ToTable("Accidente");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.AgentesTransito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rango")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AgentesTransito");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Ciudadanos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudadanos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Ciudadanos");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Localizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocalizacionAccidenteId")
                        .HasColumnType("int");

                    b.Property<string>("Longitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zona")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocalizacionAccidenteId")
                        .IsUnique();

                    b.ToTable("Localizacion");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.TablaVC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AccidenteId")
                        .HasColumnType("int");

                    b.Property<int>("AccidenteTablaVCId")
                        .HasColumnType("int");

                    b.Property<int>("ConductoresTablaVCId")
                        .HasColumnType("int");

                    b.Property<int>("VehiculosTablaVCId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccidenteId");

                    b.HasIndex("ConductoresTablaVCId")
                        .IsUnique();

                    b.HasIndex("VehiculosTablaVCId")
                        .IsUnique();

                    b.ToTable("TablaVC");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Vehiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Modelo")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Conductores", b =>
                {
                    b.HasBaseType("ViaParaTodos.App.Dominio.Entidades.Ciudadanos");

                    b.Property<DateTime>("VigenciaLicencia")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Conductores");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Vinculados", b =>
                {
                    b.HasBaseType("ViaParaTodos.App.Dominio.Entidades.Ciudadanos");

                    b.Property<int?>("AccidenteId")
                        .HasColumnType("int");

                    b.Property<bool>("Afectado")
                        .HasColumnType("bit");

                    b.Property<bool>("Testigo")
                        .HasColumnType("bit");

                    b.Property<int>("VinculadosAccidenteId")
                        .HasColumnType("int");

                    b.HasIndex("AccidenteId");

                    b.HasDiscriminator().HasValue("Vinculados");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Accidente", b =>
                {
                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.AgentesTransito", "AgentesTransito")
                        .WithMany("Accidente")
                        .HasForeignKey("AgentesTransitoId");

                    b.Navigation("AgentesTransito");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Localizacion", b =>
                {
                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.Accidente", "Accidente")
                        .WithOne("Localizacion")
                        .HasForeignKey("ViaParaTodos.App.Dominio.Entidades.Localizacion", "LocalizacionAccidenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accidente");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.TablaVC", b =>
                {
                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.Accidente", "Accidente")
                        .WithMany("TablaVC")
                        .HasForeignKey("AccidenteId");

                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.Conductores", "Conductores")
                        .WithOne("TablaVC")
                        .HasForeignKey("ViaParaTodos.App.Dominio.Entidades.TablaVC", "ConductoresTablaVCId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.Vehiculos", "Vehiculos")
                        .WithOne("TablaVC")
                        .HasForeignKey("ViaParaTodos.App.Dominio.Entidades.TablaVC", "VehiculosTablaVCId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Accidente");

                    b.Navigation("Conductores");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Vinculados", b =>
                {
                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.Accidente", "Accidente")
                        .WithMany("Vinculados")
                        .HasForeignKey("AccidenteId");

                    b.Navigation("Accidente");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Accidente", b =>
                {
                    b.Navigation("Localizacion");

                    b.Navigation("TablaVC");

                    b.Navigation("Vinculados");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.AgentesTransito", b =>
                {
                    b.Navigation("Accidente");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Vehiculos", b =>
                {
                    b.Navigation("TablaVC");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Conductores", b =>
                {
                    b.Navigation("TablaVC");
                });
#pragma warning restore 612, 618
        }
    }
}