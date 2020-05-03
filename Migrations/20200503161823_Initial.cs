using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestCar.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Prioridade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModeloCar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FabricanteId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModeloCar_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ModeloCarId = table.Column<int>(nullable: true),
                    ModeloId = table.Column<int>(nullable: false),
                    Placa = table.Column<string>(nullable: true),
                    Chassis = table.Column<string>(nullable: true),
                    Hodometro = table.Column<int>(nullable: false),
                    Cor = table.Column<string>(nullable: true),
                    AnoFab = table.Column<DateTime>(nullable: false),
                    AnoModelo = table.Column<DateTime>(nullable: false),
                    Origem = table.Column<string>(nullable: true),
                    Renavam = table.Column<int>(nullable: false),
                    ValorFipe = table.Column<double>(nullable: false),
                    ValorPago = table.Column<double>(nullable: false),
                    ValorVenda = table.Column<double>(nullable: false),
                    FabricanteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Veiculo_ModeloCar_ModeloCarId",
                        column: x => x.ModeloCarId,
                        principalTable: "ModeloCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModeloCar_FabricanteId",
                table: "ModeloCar",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_FabricanteId",
                table: "Veiculo",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_ModeloCarId",
                table: "Veiculo",
                column: "ModeloCarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "ModeloCar");

            migrationBuilder.DropTable(
                name: "Fabricante");
        }
    }
}
