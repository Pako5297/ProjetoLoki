using Loki.Dominio.Contratos.Negocio;
using Loki.Dominio.Contratos.Repositorio;
using Loki.Dominio.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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

        public CartaoCredito RetornaCartaoPorCpf(string cpf)
        {
            return _cartaoRepositorio.RetornaCartaoPorCpf(cpf);
        }

        public IList<CartaoCredito> RetornaTodosCartoes()
        {
            return _cartaoRepositorio.RetornaTodosCartoes();
        }

        public void DeletarDados(int id)
        {
            _cartaoRepositorio.DeletarDados(id);
        }
    }

    
}
