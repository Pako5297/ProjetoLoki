using Loki.Dominio.Entidades;
using System.Collections.Generic;

namespace Loki.Dominio.Contratos.Repositorio
{
    public interface ICartaoCreditoRepositorio : IRepositorio<CartaoCredito>
    {
        void SalvarDados(CartaoCredito cartaoCredito);
        void DeletarDados(int id);
        public CartaoCredito RetornaCartaoPorCpf(string cpf);
        public IList<CartaoCredito> RetornaTodosCartoes();

    }
}
