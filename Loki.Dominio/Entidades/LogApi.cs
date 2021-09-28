using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loki.Dominio.Entidades
{
    public class LogApi
    {
        public int Id { get; set; }
        public string Request { get; set; }
        public DateTime DataGravacao { get; set; }

    }
}
