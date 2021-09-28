using Loki.Dominio.Contratos.Repositorio;
using Loki.Dominio.Entidades;
using Loki.Infra.Data.Contexto;

namespace Loki.Infra.Data
{
    public class CartaoCreditoRepositorio : Repositorio<CartaoCredito>, ICartaoCreditoRepositorio
    {
        
   
        public CartaoCreditoRepositorio(LokiContext context) : base(context)
        {   
        }

        public void SalvarDados(CartaoCredito cartaoCredito)
        {
            _context.CartaoCreditos.Add(cartaoCredito);
            _context.SaveChanges();
        }
    }
}
