using BackEnd.Models;
using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IShippersService
    {
        IEnumerable<ShippersModel> GetShippers();
        ShippersModel GetById(int id);
        bool AddShippers(ShippersModel shippers);
        bool UpdateShippers(ShippersModel shippers);
        bool DeleteShippers(ShippersModel shippers);
    }
}
