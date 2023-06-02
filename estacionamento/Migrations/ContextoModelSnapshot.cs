﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using estacionamento.Models;

#nullable disable

namespace estacionamento.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("estacionamento.Models.EstoqueModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("Ano")
                        .HasColumnType("smallint")
                        .HasColumnName("Ano");

                    b.Property<bool>("Automatico")
                        .HasColumnType("bit")
                        .HasColumnName("Automatico");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cor");

                    b.Property<bool>("Dispinivel")
                        .HasColumnType("bit")
                        .HasColumnName("Diponivel");

                    b.Property<DateTime>("Entrada")
                        .HasColumnType("datetime2")
                        .HasColumnName("Entrada");

                    b.Property<int>("Km")
                        .HasColumnType("int")
                        .HasColumnName("Km");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Marca");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Modelo");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Placa");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Preco");

                    b.Property<DateTime>("Saida")
                        .HasColumnType("datetime2")
                        .HasColumnName("Saida");

                    b.HasKey("Id");

                    b.ToTable("Estoque");
                });
#pragma warning restore 612, 618
        }
    }
}
