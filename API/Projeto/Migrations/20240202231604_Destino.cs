using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto.Migrations
{
    /// <inheritdoc />
    public partial class Destino : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "projeto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDestino = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PromocoesDestino = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorDestino = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorPromocionalDestino = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projeto", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "projeto",
                columns: new[] { "id", "Descricao", "Foto", "NomeDestino", "PromocoesDestino", "ValorDestino", "ValorPromocionalDestino" },
                values: new object[] { 1, "São mais de 40 praias ao redor da ilha principal, além de outras ilhotas que fazem parte do arquipélago. Além disso, com 83% de Mata Atlântica preservada, o Parque Estadual de Ilhabela tem atrações de ecoturismo para todos os perfis, de famílias com crianças aos mais aventureiros. Possui um território de 348 km², 36 Km de praias e ainda, possui 360 cachoeiras, além disso, ela é um dos únicos municípios-arquipélagos marinhos do Brasil. Uma maravilha de Arquipélago.", "https://karinabertolazzo.github.io/PrimeiraEntrega/assets/img/card_ilhadascabras.jpeg", "IlhaBela", "Promoção 1", "R$ 590", "R$ 390" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "projeto");
        }
    }
}
