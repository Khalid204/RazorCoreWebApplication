using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private EmployeeContext _context;
        private DbSet<T> table = null;
        public GenericRepository(EmployeeContext moDbContext)
        {
            _context = moDbContext;
            table = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.UpdateRange(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
