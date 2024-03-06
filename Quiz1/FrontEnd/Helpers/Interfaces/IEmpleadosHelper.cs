using FrontEnd.Models;
using System.Collections.Generic;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IEmpleadosHelper
    {
        List<EmpleadosViewModel> GetEmpleados();
        EmpleadosViewModel GetEmpleados(int id);
        EmpleadosViewModel AddEmpleados(EmpleadosViewModel empleado);
        EmpleadosViewModel UpdateEmpleados(EmpleadosViewModel empleado);
        EmpleadosViewModel DeleteEmpleados(int id);
        EmpleadosViewModel GetAll();
    }
}
