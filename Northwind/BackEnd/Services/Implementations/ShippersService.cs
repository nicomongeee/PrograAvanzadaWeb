using BackEnd.Models;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Services.Implementations
{
    public class ShippersService : IShippersService
    {

        public IUnidadDeTrabajo _unidadDeTrabajo;

        public ShippersService(IUnidadDeTrabajo unidadDeTrabajo) 
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public bool AddShippers(ShippersModel shippers)
        {
            Shippers entity = new Shippers
            {
                ShipperId = shippers.ShipperId,
                CompanyName = shippers.CompanyName,
                Phone = shippers.Phone
        };
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

            ShippersModel shippersModel = new ShippersModel
            {
                ShipperId = entity.ShipperId,
                CompanyName = entity.CompanyName,
                Phone = entity.Phone
            };
            return shippersModel;
        }

        public IEnumerable<ShippersModel> GetShippers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateShippers(ShippersModel shippers)
        {
            throw new NotImplementedException();
        }
    }
}
