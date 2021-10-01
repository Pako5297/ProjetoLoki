using AutoMapper;
using Loki.Dominio.Contratos.Negocio;
using Loki.Dominio.Entidades;
using Loki.Negocio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loki.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaoCreditoController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly ICartaoCreditoNegocio _cartaoCredito;
        public CartaoCreditoController(ICartaoCreditoNegocio cartaoCredito, IMapper mapper)
        {
            _cartaoCredito = cartaoCredito;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult RetornaTodosCartoes()
        {
            var listCartao = _cartaoCredito.RetornaTodosCartoes();
            return Ok(listCartao);
        }

        [HttpGet("cpf")]
        public IActionResult RetornaPorCpf([FromHeader] string cpf)
        {
            var cartaoCpf = _cartaoCredito.RetornaCartaoPorCpf(cpf);
            return Ok(cartaoCpf);
        }

        [HttpDelete("cpf")]
        public IActionResult ExcluirDados([FromHeader] int id)
        {
            _cartaoCredito.DeletarDados(id);
            return Ok();
        }


        [HttpPost]
        public IActionResult Post([FromBody]CartaoCreditoModel cartao)
        {
            _cartaoCredito.SalvarDados(_mapper.Map<CartaoCredito>(cartao));
            
            return Ok();
        }
        

    }
}
