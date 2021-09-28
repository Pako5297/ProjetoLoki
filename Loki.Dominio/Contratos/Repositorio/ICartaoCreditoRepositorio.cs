using Loki.Dominio.Entidades;

namespace Loki.Dominio.Contratos.Repositorio
{
    public interface ICartaoCreditoRepositorio : IRepositorio<CartaoCredito>
    {
        void SalvarDados(CartaoCredito cartaoCredito);

    }
}
