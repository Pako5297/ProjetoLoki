using Loki.Dominio.Contratos.Negocio;
using Loki.Dominio.Contratos.Repositorio;
using Loki.Dominio.Entidades;
using Newtonsoft.Json;
using System;
namespace Loki.Negocio
{
    public class CartaoCreditoNegocio : ICartaoCreditoNegocio
    {
        private readonly ICartaoCreditoRepositorio _cartaoRepositorio;
        private readonly ILogApiRepositorio _logRepositorio;

        public CartaoCreditoNegocio(ICartaoCreditoRepositorio cartaoRepositorio, ILogApiRepositorio logRepositorio)
        {
            _cartaoRepositorio = cartaoRepositorio;
            _logRepositorio = logRepositorio;
        }
        public void SalvarDados(CartaoCredito cartaoCredito)
        {
            _cartaoRepositorio.SalvarDados(cartaoCredito);
            _logRepositorio.SalvarDados(new LogApi
            {
                DataGravacao = DateTime.Now,
                Request = JsonConvert.SerializeObject(cartaoCredito)
            });
        }
    }

    
}
