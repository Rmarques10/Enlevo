using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Enlevo.Models
{
    public class Faturamento
    {
        [Key]
        public int FaturamentoId { get; set; }
        [Display(Name = "Valor Total")]
        public decimal ValorTotal { get; set; }


    }
}
