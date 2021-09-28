using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loki.Negocio.Models
{
    public class LogApiModel
    {
        public int Id { get; set; }
        public string Request { get; set; }
        public DateTime DataGravacao { get; set; }
    }
}
