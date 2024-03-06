using BackEnd.Models;
using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IDistritosService
    {
        IEnumerable<DistritosModel> GetDistritos();
        DistritosModel GetById(int id);
        bool AddDistritos(DistritosModel distritos);
        bool UpdateDistritos(DistritosModel distritos);
        bool DeleteDistritos(DistritosModel distritos);
    }
}
