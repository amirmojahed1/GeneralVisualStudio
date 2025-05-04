using Core.Interfaces;
using DataAccessLibrary.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll() => _dbSet.ToList();
        public T GetById(int id) => _dbSet.Find(id);
        public bool Insert(T entity) { _dbSet.Add(entity); return _context.SaveChanges() > 0; }
        public bool Update(T entity) { _context.Entry(entity).State = EntityState.Modified; return _context.SaveChanges() > 0; }
        public bool Delete(T entity) { _dbSet.Remove(entity); return _context.SaveChanges() > 0; }
        public bool Delete(int id) { var entity = GetById(id); if (entity == null) return false; _dbSet.Remove(entity); return _context.SaveChanges() > 0; }
        public void Save() => _context.SaveChanges();

        // Implement Dispose to clean up resources
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
