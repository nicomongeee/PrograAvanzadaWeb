using DAL.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Implementations
{
    public class DALGenerioImpl<TEntity> : IDALGenerico<TEntity> where TEntity : class
    {
        protected readonly ExamenContext _context;

        public DALGenerioImpl(ExamenContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public bool Add(TEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges(); 
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
    }
}
