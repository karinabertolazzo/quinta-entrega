//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto.Model
{

    [ Table("projeto")]

    public class ProjetoAgencia
    {



       [Column("id")] 
    

    public int Id { get; set; }
    
     public string NomeDestino { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;

    
    public string Foto { get; set; } = string.Empty;


    public string PromocoesDestino { get; set; } = string.Empty;

     public string ValorDestino { get; set; } = string.Empty;

      public string ValorPromocionalDestino { get; set; }  = string.Empty;




}

}