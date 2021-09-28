using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loki.Dominio.Contratos.Repositorio;
using Loki.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Loki.Infra.Data
{
    public class Repositorio<T> : IDisposable, IRepositorio<T> where T : class
    {
        protected internal readonly LokiContext _context;

        public Repositorio(LokiContext context)
        {
            _context = context;
        }
        public void Adicionar(T item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
        public void Excluir(T item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
        public void Editar(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
        public virtual T ObterPorId(object id)
        {
            return _context.Set<T>().Find(id);
        }
        public virtual IQueryable<T> ObterTudo()
        {
            return _context.Set<T>();
        }
        
        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
