using Loki.Dominio.Contratos.Repositorio;
using Loki.Dominio.Entidades;
using Loki.Infra.Data.Contexto;
using System.Collections.Generic;
using System.Linq;

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

        public CartaoCredito RetornaCartaoPorCpf(string cpf)
        {
            return _context.CartaoCreditos.FirstOrDefault(obj => obj.Cpf == cpf);
        }

        public IList<CartaoCredito> RetornaTodosCartoes()
        {
            return _context.CartaoCreditos.ToList();
        }

        public void DeletarDados(int id)
        {
            var excluir = _context.CartaoCreditos.Find(id);
            _context.CartaoCreditos.Remove(excluir);
            _context.SaveChanges();
        }
    }
}
