using Domain.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private AppDBContext _dbContext;
        private DbSet<T> _dbSet;

        public BaseRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public T? Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            _dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return [.. _dbSet.ToList()];
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T? Update(T entity)
        {
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
