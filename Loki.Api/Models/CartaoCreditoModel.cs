using Loki.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Loki.Api.Models
{
    public class CartaoCreditoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string DataValidade { get; set; }
        public int Cvv { get; set; }
        public string Bandeira { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Nascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }
    }
}
