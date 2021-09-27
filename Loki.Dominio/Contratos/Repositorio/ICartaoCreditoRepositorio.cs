using Loki.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loki.Dominio.Contratos.Repositorio
{
    public interface ICartaoCreditoRepositorio
    {
        void SalvarDados(CartaoCredito cartaoCredito);

    }
}
