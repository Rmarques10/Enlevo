using Enlevo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enlevo.Contexts
{
    public class AdegaContext : DbContext
    {
        public AdegaContext(DbContextOptions op) : base(op)
        {

        }

        public DbSet<Cliente> Clientes  { get; set; }
        public DbSet<Faturamento> Faturamentos  { get; set; }
        public DbSet<Produto> Produtos  { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }   
}
