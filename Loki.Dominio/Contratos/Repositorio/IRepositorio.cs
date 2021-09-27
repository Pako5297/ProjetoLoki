using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loki.Dominio.Contratos.Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        void Adicionar(T item);
        void Excluir(T item);
        void Editar(T item);
        T ObterPorId(object id);
        IQueryable<T> ObterTudo();
    }
}
