using BackEnd.Models;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace BackEnd.Services.Implementations
{
    public class ShippersService : IShippersService
    {

        public IUnidadDeTrabajo _unidadDeTrabajo;

        public ShippersService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        ShippersModel Convertir(Shipper shippers)
        {
            return new ShippersModel
            {
                ShipperId = shippers.ShipperId,
                CompanyName = shippers.CompanyName,
                Phone = shippers.Phone
            };
        }

        Shipper Convertir(ShippersModel shippers)
        {
            return new Shipper
            {
                ShipperId = shippers.ShipperId,
                CompanyName = shippers.CompanyName,
                Phone = shippers.Phone
            };
        }

        public bool AddShippers(ShippersModel shippers)
        {
            Shipper entity = Convertir(shippers);
            _unidadDeTrabajo._shippersDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        public bool DeleteShippers(ShippersModel shippers)
        {
            throw new NotImplementedException();
        }

        public ShippersModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._shippersDAL.Get(id);

            ShippersModel shippersModel = Convertir(entity);
            return shippersModel;
        }

        public IEnumerable<ShippersModel> GetShippers()
        {
            var result = _unidadDeTrabajo._shippersDAL.GetAll();
            List<ShippersModel> lista = new List<ShippersModel>();
            foreach (var shippers in result)
            {
                lista.Add(Convertir(shippers));
            }
            return lista;
        }

        public bool UpdateShippers(ShippersModel shippers)
        {
            throw new NotImplementedException();
        }
    }
}
