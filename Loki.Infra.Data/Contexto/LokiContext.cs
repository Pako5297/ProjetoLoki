using Loki.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loki.Infra.Data.Contexto
{
    public class LokiContext : DbContext
    {
        public LokiContext(DbContextOptions<LokiContext> options)
            : base(options)
        {
        }
        public DbSet<CartaoCredito> CartaoCreditos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        
    }
}
