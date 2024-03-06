using BackEnd.Models;

namespace BackEnd.Services.Interfaces
{
    public interface IEmpleadosService
    {
        IEnumerable<EmpleadosModel> GetEmpleados();
        EmpleadosModel GetById(int id);
        bool AddEmpleados(EmpleadosModel empleado);
        bool UpdateEmpleados(EmpleadosModel empleado);
        bool DeleteEmpleados(EmpleadosModel empleado);
    }
}
