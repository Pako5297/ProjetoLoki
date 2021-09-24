using Loki.Dominio.Contratos.Negocio;
using Loki.Dominio.Contratos.Repositorio;
using Loki.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loki.Negocio
{
    public class CartaoCreditoNegocio : ICartaoCreditoNegocio
    {
        private readonly ICartaoCreditoRepositorio _cartaoRepositorio;
        
        public CartaoCreditoNegocio(ICartaoCreditoRepositorio cartaoRepositorio)
        {
            _cartaoRepositorio = cartaoRepositorio;
        }
        public bool SalvarDados(CartaoCredito cartaoCredito)
        {
            var resultado = _cartaoRepositorio.SalvarDados(cartaoCredito);
            throw new NotImplementedException();
        }
    }

    
}
