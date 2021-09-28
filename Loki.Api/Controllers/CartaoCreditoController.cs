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


        [HttpPost]
        public IActionResult Post([FromBody]CartaoCreditoModel cartao)
        {
            _cartaoCredito.SalvarDados(_mapper.Map<CartaoCredito>(cartao));
            
            return Ok();
        }
        

    }
}
