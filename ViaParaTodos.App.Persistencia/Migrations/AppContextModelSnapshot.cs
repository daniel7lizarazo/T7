﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ViaParaTodos.App.Persistencia.AppRepositorios;

namespace ViaParaTodos.App.Persistencia.Migrations
{
    [DbContext(typeof(AppRepositorios.AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("AccidenteLocalizacionId")
                        .HasColumnType("int");

                    b.Property<int?>("AgenteId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gravedad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccidenteLocalizacionId")
                        .IsUnique();

                    b.HasIndex("AgenteId");

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

                    b.Property<string>("Latitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zona")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Localizacion");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.TablaVA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AccidenteId")
                        .HasColumnType("int");

                    b.Property<int>("AcidenteId")
                        .HasColumnType("int");

                    b.Property<int>("VinculadosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccidenteId");

                    b.HasIndex("VinculadosId");

                    b.ToTable("TablaVA");
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

                    b.Property<bool>("Afectado")
                        .HasColumnType("bit");

                    b.Property<bool>("Testigo")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Vinculados");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Accidente", b =>
                {
                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.Localizacion", "Localizacion")
                        .WithOne("Accidente")
                        .HasForeignKey("ViaParaTodos.App.Dominio.Entidades.Accidente", "AccidenteLocalizacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.AgentesTransito", "Agente")
                        .WithMany("Accidente")
                        .HasForeignKey("AgenteId");

                    b.Navigation("Agente");

                    b.Navigation("Localizacion");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.TablaVA", b =>
                {
                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.Accidente", "Accidente")
                        .WithMany("TablaVA")
                        .HasForeignKey("AccidenteId");

                    b.HasOne("ViaParaTodos.App.Dominio.Entidades.Vinculados", "Vinculados")
                        .WithMany("TablaVA")
                        .HasForeignKey("VinculadosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accidente");

                    b.Navigation("Vinculados");
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

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Accidente", b =>
                {
                    b.Navigation("TablaVA");

                    b.Navigation("TablaVC");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.AgentesTransito", b =>
                {
                    b.Navigation("Accidente");
                });

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Localizacion", b =>
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

            modelBuilder.Entity("ViaParaTodos.App.Dominio.Entidades.Vinculados", b =>
                {
                    b.Navigation("TablaVA");
                });
#pragma warning restore 612, 618
        }
    }
}
