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
    public class CartaoCreditoRepositorio : ICartaoCreditoRepositorio
    {
        private readonly LokiContext _context;
        public CartaoCreditoRepositorio(LokiContext context)
        {
            _context = context;
        }
        public bool Inserir(CartaoCredito cartao)
        {
            var dB = _context.Add(cartao);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public bool SalvarDados(CartaoCredito cartaoCredito)
        {
            throw new NotImplementedException();
        }
    }
}
