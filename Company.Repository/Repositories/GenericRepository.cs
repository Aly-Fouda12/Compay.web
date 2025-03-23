using Company.Data.contexts;
using Company.Data.Models;
using Company.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly CompanyDbcontext _context;

        public GenericRepository(CompanyDbcontext context)
        {
            _context = context;
        }
        void IGenericRepository<T>.Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        void IGenericRepository<T>.Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        IEnumerable<T> IGenericRepository<T>.GetAll() => _context.Set<T>().AsEnumerable();

        T IGenericRepository<T>.GetById(int id) => _context.Set<T>().FirstOrDefault(e => e.Id == id);

        void IGenericRepository<T>.Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
