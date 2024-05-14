﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgenteInmLandingAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240510204901_CiudadTable")]
    partial class CiudadTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.AgenteInmobiliario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdAgenteInmobiliario");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AgentesInmobiliarios");
                });

            modelBuilder.Entity("Entities.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCliente");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Estado")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("PropiedadesDeInteres");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Entities.Models.Propiedad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPropiedad");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Disponible")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("MetrosCuadrados")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("NumBanos")
                        .HasColumnType("int");

                    b.Property<int>("NumHabitaciones")
                        .HasColumnType("int");

                    b.Property<int>("NumParqueaderos")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Provincia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Propiedades");
                });

            modelBuilder.Entity("Entities.Models.TipoPropiedad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTipoPropiedad");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoPropiedades");
                });

            modelBuilder.Entity("Entities.Models.Visita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdVisita");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Visitas");
                });
#pragma warning restore 612, 618
        }
    }
}