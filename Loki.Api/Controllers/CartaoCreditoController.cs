using Loki.Api.Models;
using Loki.Dominio.Contratos.Negocio;
using Loki.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loki.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaoCreditoController : ControllerBase
    {
        private readonly ICartaoCreditoNegocio _cartaoCredito;
        public CartaoCreditoController(ICartaoCreditoNegocio cartaoCredito)
        {
            _cartaoCredito = cartaoCredito;
        }

        private CartaoCredito RetornarCartaoCredito(CartaoCreditoModel model)
        {
            return new CartaoCredito
            {
                Bandeira = model.Bandeira,
                Cpf = model.Cpf,
                Cvv = model.Cvv,
                DataValidade = model.DataValidade,
                Email = model.Email,
                Enderecos = model.Enderecos,
                Nascimento = model.Nascimento,
                Nome = model.Nome,
                Numero = model.Numero,
                Rg = model.Rg,
                Senha = model.Senha
            };
        }

        [HttpPost]
        public IActionResult Post(CartaoCreditoModel cartao)
        {
            _cartaoCredito.SalvarDados(RetornarCartaoCredito(cartao));
            
            return Ok();
        }
        

    }
}
