using DAL.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class DALGenerioImpl<TEntity> : IDALGenerico<TEntity> where TEntity : class
    {

        protected readonly QuizContext _Context;
        private QuizContext context;

        public DALGenerioImpl(QuizContext quizContext)
        {
            _Context = quizContext;
        }
        public bool Add(TEntity entity)
        {
            try
            {
                _Context.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar la entidad: {ex.Message}");
                // También puedes registrar ex.StackTrace si necesitas más detalles
                return false;
            }
        }


        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            return _Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>().ToList();
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _Context.Set<TEntity>().Attach(entity);
                _Context.Set<TEntity>().Remove(entity);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _Context.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
