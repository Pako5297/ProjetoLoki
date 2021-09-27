using Loki.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loki.Infra.Data.Contexto
{
    public class LokiContext : DbContext
    {
        public readonly IConfiguration Configuration;
        public LokiContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("LokiContext"));
        }
        public DbSet<CartaoCredito> CartaoCreditos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        
    }
}
