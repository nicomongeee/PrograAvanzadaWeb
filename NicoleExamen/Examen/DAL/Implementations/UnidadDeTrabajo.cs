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
        public IDistritosDAL _distritoDAL { get; }

        private readonly ExamenContext _context;

        public UnidadDeTrabajo(ExamenContext examenContext,
                               IDistritosDAL distritoDAL
                                )
        {
            _context = new ExamenContext();
            _distritoDAL = distritoDAL;
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
