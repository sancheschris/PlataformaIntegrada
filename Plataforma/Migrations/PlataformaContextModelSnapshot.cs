﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plataforma.Data;

namespace Plataforma.Migrations
{
    [DbContext(typeof(PlataformaContext))]
    partial class PlataformaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Plataforma.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Plataforma.Models.ClienteRanking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataCalculo");

                    b.Property<int>("Ranking");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("ClienteRanking");
                });

            modelBuilder.Entity("Plataforma.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descrição");

                    b.Property<double>("PrecoUnitario");

                    b.Property<int>("QtdEstoque");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Plataforma.Models.PedidoVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataEntrega");

                    b.Property<DateTime>("DataPedido");

                    b.Property<double>("PorcetagemDesconto");

                    b.Property<double>("ValorTotalPedido");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("PedidoVenda");
                });

            modelBuilder.Entity("Plataforma.Models.PedidoVendaLinhas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId");

                    b.Property<double>("PrecoUnitario");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("PedidoVendaLinhas");
                });

            modelBuilder.Entity("Plataforma.Models.ClienteRanking", b =>
                {
                    b.HasOne("Plataforma.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Plataforma.Models.PedidoVenda", b =>
                {
                    b.HasOne("Plataforma.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Plataforma.Models.PedidoVendaLinhas", b =>
                {
                    b.HasOne("Plataforma.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
