using AutoMapper;
using Loki.Dominio.Entidades;
using Loki.Negocio.Models;

namespace Loki.Negocio.Mappers
{
    public class CartaoCreditoMapper : Profile
    {
        public CartaoCreditoMapper()
        {
            CreateMap<CartaoCreditoModel, CartaoCredito>();
            CreateMap<CartaoCredito, CartaoCreditoModel>();
        }
    }
}
