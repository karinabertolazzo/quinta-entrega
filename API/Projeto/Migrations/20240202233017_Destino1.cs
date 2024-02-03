using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projeto.Migrations
{
    /// <inheritdoc />
    public partial class Destino1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "projeto",
                keyColumn: "id",
                keyValue: 1,
                column: "Foto",
                value: "https://raw.githubusercontent.com/karinabertolazzo/PrimeiraEntrega/main/assets/img/card_ilhadascabras.jpeg");

            migrationBuilder.InsertData(
                table: "projeto",
                columns: new[] { "id", "Descricao", "Foto", "NomeDestino", "PromocoesDestino", "ValorDestino", "ValorPromocionalDestino" },
                values: new object[,]
                {
                    { 2, "As Maldivas estão entre os melhores lugares do mundo para mergulhar. São quase 30 espécies de tubarões, mantas gigantes e vida marinha avassaladora. Os melhores meses para o mergulho são de dezembro a março, no auge da alta temporada, quando as águas do mar ficam ainda mais cristalinas. Nadar ao lado de peixes coloridos, fazer um cruzeiro por várias ilhas, jantar em um restaurante subaquático e até mergulhar em um “mar de estrelas”.", "https://raw.githubusercontent.com/karinabertolazzo/PrimeiraEntrega/main/assets/img/card_maldivas.jpg", "Maldivas", "Promoção 2", "R$ 2.464", "R$ 2000" },
                    { 3, "Zanzibar é uma ilha sensacional localizada no sudeste do continente africano. Ainda pouco conhecido pelos viajantes, o destino é exótico, o que colabora para dar um ar roots ao lugar. E um detalhe importante: o arquipélago é banhado pelas águas do oceano Pacífico. Zanzibar é um prato cheio para viajantes que gostam de lugares exóticos e com muitas belezas naturais, mas que prezam pelo fator cultural. visite alguns pontos turísticos.", "https://raw.githubusercontent.com/karinabertolazzo/PrimeiraEntrega/main/assets/img/card_zanzibar.jpg", "Zamzimar", "Promoção 3", "R$ 2.199", "R$ 2000" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "projeto",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "projeto",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "projeto",
                keyColumn: "id",
                keyValue: 1,
                column: "Foto",
                value: "https://karinabertolazzo.github.io/PrimeiraEntrega/assets/img/card_ilhadascabras.jpeg");
        }
    }
}
