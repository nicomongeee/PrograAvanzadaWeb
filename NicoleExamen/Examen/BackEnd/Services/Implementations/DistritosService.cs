using BackEnd.Models;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace BackEnd.Services.Implementations
{
    public class DistritosService : IDistritosService
    {

        public IUnidadDeTrabajo _unidadDeTrabajo;

        public DistritosService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        DistritosModel Convertir(Distrito distritos)
        {
            return new DistritosModel
            {
                DistritoId = distritos.DistritoId,
                Nombre = distritos.Nombre
            };
        }

        Distrito Convertir(DistritosModel distritos)
        {
            return new Distrito
            {
                DistritoId = distritos.DistritoId,
                Nombre = distritos.Nombre
            };
        }

        public bool AddDistritos(DistritosModel distritos)
        {
            Distrito entity = Convertir(distritos);
            _unidadDeTrabajo._distritoDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        public bool DeleteDistritos(DistritosModel distritos)
        {
            throw new NotImplementedException();
        }

        public DistritosModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._distritoDAL.Get(id);

            DistritosModel distritosModel = Convertir(entity);
            return distritosModel;
        }

        public IEnumerable<DistritosModel> GetDistritos()
        {
            var result = _unidadDeTrabajo._distritoDAL.GetAll();
            List<DistritosModel> lista = new List<DistritosModel>();
            foreach (var distritos in result)
            {
                lista.Add(Convertir(distritos));
            }
            return lista;
        }
        public bool UpdateDistritos(DistritosModel distritos)
        {
            throw new NotImplementedException();
        }

    }
}
