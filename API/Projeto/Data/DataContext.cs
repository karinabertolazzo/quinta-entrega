using Projeto.Model;
using Microsoft.EntityFrameworkCore;


namespace Projeto.Data
{
    public class DataContext : DbContext

    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<ProjetoAgencia>Projeto{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        
            modelBuilder.Entity<ProjetoAgencia>().HasData(
                new ProjetoAgencia { Id = 1, NomeDestino = "IlhaBela", 
                Descricao = "São mais de 40 praias ao redor da ilha principal, além de outras ilhotas que fazem parte do arquipélago. Além disso, com 83% de Mata Atlântica preservada, o Parque Estadual de Ilhabela tem atrações de ecoturismo para todos os perfis, de famílias com crianças aos mais aventureiros. Possui um território de 348 km², 36 Km de praias e ainda, possui 360 cachoeiras, além disso, ela é um dos únicos municípios-arquipélagos marinhos do Brasil. Uma maravilha de Arquipélago.", Foto = "https://raw.githubusercontent.com/karinabertolazzo/PrimeiraEntrega/main/assets/img/card_ilhadascabras.jpeg", PromocoesDestino = "Promoção 1", 
                ValorDestino = "Valor R$ 590", ValorPromocionalDestino = "Valor Promocional R$ 390", 
                
            }
            );

            modelBuilder.Entity<ProjetoAgencia>().HasData(
                new ProjetoAgencia { Id = 2, NomeDestino = "Maldivas", 
                Descricao = "As Maldivas estão entre os melhores lugares do mundo para mergulhar. São quase 30 espécies de tubarões, mantas gigantes e vida marinha avassaladora. Os melhores meses para o mergulho são de dezembro a março, no auge da alta temporada, quando as águas do mar ficam ainda mais cristalinas. Nadar ao lado de peixes coloridos, fazer um cruzeiro por várias ilhas, jantar em um restaurante subaquático e até mergulhar em um “mar de estrelas”.", Foto = "https://raw.githubusercontent.com/karinabertolazzo/PrimeiraEntrega/main/assets/img/card_maldivas.jpg", PromocoesDestino = "Promoção 2", 
                ValorDestino = "Valor R$ 2.464", ValorPromocionalDestino = "Valor Promocional R$ 2000", 
                
            }
            );

            modelBuilder.Entity<ProjetoAgencia>().HasData(
                new ProjetoAgencia { Id = 3, NomeDestino = "Zamzimar", 
                Descricao = "Zanzibar é uma ilha sensacional localizada no sudeste do continente africano. Ainda pouco conhecido pelos viajantes, o destino é exótico, o que colabora para dar um ar roots ao lugar. E um detalhe importante: o arquipélago é banhado pelas águas do oceano Pacífico. Zanzibar é um prato cheio para viajantes que gostam de lugares exóticos e com muitas belezas naturais, mas que prezam pelo fator cultural. visite alguns pontos turísticos.", Foto = "https://raw.githubusercontent.com/karinabertolazzo/PrimeiraEntrega/main/assets/img/card_zanzibar.jpg", PromocoesDestino = "Promoção 3", 
                ValorDestino = "Valor R$ 2.199", ValorPromocionalDestino = "Valor Promocional R$ 2000", 
                
            }
            );
            
        }   


    } 
}
