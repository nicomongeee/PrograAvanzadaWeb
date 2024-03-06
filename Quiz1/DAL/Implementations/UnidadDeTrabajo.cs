using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public IEmpleadosDAL _empleadosDAL { get; }

        private readonly QuizContext _context;

        public UnidadDeTrabajo(QuizContext quizContext, IEmpleadosDAL empleadosDAL)
        {
            _context = quizContext;
            _empleadosDAL = empleadosDAL;
        }

        public bool Complete()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
