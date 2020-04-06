using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Enlevo.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Display(Name = "Nome Usuário")]
        public string NomeUsuario { get; set; }
        [Display(Name = "Email")]
        public string EmailUsuario { get; set; }
        [Display(Name = "Senha")]
        public string SenhaUsuario { get; set; }
    }
}
