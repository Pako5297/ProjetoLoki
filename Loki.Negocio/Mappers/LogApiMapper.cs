using AutoMapper;
using Loki.Dominio.Entidades;
using Loki.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loki.Negocio.Mappers
{
    public class LogApiMapper : Profile
    {
        public LogApiMapper()
        {
            CreateMap<LogApiModel, LogApi>();
            CreateMap<LogApi, LogApiModel>();
        }
    }
}

