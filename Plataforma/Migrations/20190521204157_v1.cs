using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plataforma.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClienteRanking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ranking = table.Column<int>(nullable: false),
                    DataCalculo = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteRanking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClienteRanking_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descrição = table.Column<string>(nullable: true),
                    PrecoUnitario = table.Column<double>(nullable: false),
                    QtdEstoque = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PedidoVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataPedido = table.Column<DateTime>(nullable: false),
                    DataEntrega = table.Column<DateTime>(nullable: false),
                    PorcetagemDesconto = table.Column<double>(nullable: false),
                    ValorTotalPedido = table.Column<double>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoVenda_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoVendaLinhas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrecoUnitario = table.Column<double>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoVendaLinhas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoVendaLinhas_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteRanking_ClienteId",
                table: "ClienteRanking",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoVenda_ClienteId",
                table: "PedidoVenda",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoVendaLinhas_ItemId",
                table: "PedidoVendaLinhas",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteRanking");

            migrationBuilder.DropTable(
                name: "PedidoVenda");

            migrationBuilder.DropTable(
                name: "PedidoVendaLinhas");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
