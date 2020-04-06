using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Enlevo.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Display(Name = "Nome Cliente")]
        public string NomeCliente { get; set; }
        [Display(Name = "Telefone")]
        public int TelefoneCliente { get; set; }


    }
}
