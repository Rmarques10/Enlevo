using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Enlevo.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Display(Name = "Nome Produto")]
        public string NomeProduto { get; set; }
        [Display(Name = "Quantidade")]
        public int QuantidadeProduto { get; set; }
        [Display(Name = "Valor")]
        public decimal ValorProduto { get; set; }

    }
}
