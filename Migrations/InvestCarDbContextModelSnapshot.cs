﻿// <auto-generated />
using System;
using InvestCar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvestCar.Migrations
{
    [DbContext(typeof(InvestCarDbContext))]
    partial class InvestCarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InvestCar.Models.Fabricante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int>("Prioridade");

                    b.Property<string>("Site");

                    b.HasKey("Id");

                    b.ToTable("Fabricante");
                });

            modelBuilder.Entity("InvestCar.Models.ModeloCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FabricanteId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("FabricanteId");

                    b.ToTable("ModeloCar");
                });

            modelBuilder.Entity("InvestCar.Models.Veiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AnoFab");

                    b.Property<DateTime>("AnoModelo");

                    b.Property<string>("Chassis");

                    b.Property<string>("Cor");

                    b.Property<int?>("FabricanteId");

                    b.Property<int>("Hodometro");

                    b.Property<int?>("ModeloCarId");

                    b.Property<int>("ModeloId");

                    b.Property<string>("Origem");

                    b.Property<string>("Placa");

                    b.Property<int>("Renavam");

                    b.Property<double>("ValorFipe");

                    b.Property<double>("ValorPago");

                    b.Property<double>("ValorVenda");

                    b.HasKey("Id");

                    b.HasIndex("FabricanteId");

                    b.HasIndex("ModeloCarId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("InvestCar.Models.ModeloCar", b =>
                {
                    b.HasOne("InvestCar.Models.Fabricante", "Fabricante")
                        .WithMany("ModeloCar")
                        .HasForeignKey("FabricanteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InvestCar.Models.Veiculo", b =>
                {
                    b.HasOne("InvestCar.Models.Fabricante", "Fabricante")
                        .WithMany()
                        .HasForeignKey("FabricanteId");

                    b.HasOne("InvestCar.Models.ModeloCar", "ModeloCar")
                        .WithMany()
                        .HasForeignKey("ModeloCarId");
                });
#pragma warning restore 612, 618
        }
    }
}
