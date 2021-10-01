using Loki.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loki.Dominio.Contratos.Negocio
{
    public interface ICartaoCreditoNegocio
    {
        public void SalvarDados(CartaoCredito cartaoCredito);
        void DeletarDados(int id);
        public CartaoCredito RetornaCartaoPorCpf(string cpf);
        public IList<CartaoCredito> RetornaTodosCartoes();
    }
}
