using Loki.Dominio.Contratos.Repositorio;
using Loki.Dominio.Entidades;
using Loki.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loki.Infra.Data
{
    public class LogApiRepositorio : Repositorio<LogApi>, ILogApiRepositorio
    {


        public LogApiRepositorio(LokiContext context) : base(context)
        {
        }

        public void SalvarDados(LogApi logApi)
        {
            _context.Api.Add(logApi);
            _context.SaveChanges();
        }
    }
}
