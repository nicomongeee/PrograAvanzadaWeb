using BackEnd.Models;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class EmpleadosService : IEmpleadosService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public EmpleadosService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }
        EmpleadosModel Convertir(Empleado empleado)
        {
            return new EmpleadosModel
            {
                EmpleadoId = empleado.EmpleadoId,
                Nombre = empleado.Nombre,
                Salario = empleado.Salario
            };
        }

        Empleado Convertir(EmpleadosModel empleado)
        {
            return new Empleado
            {
                EmpleadoId = empleado.EmpleadoId,
                Nombre = empleado.Nombre,
                Salario = empleado.Salario
            };
        }

        public bool AddEmpleados(EmpleadosModel empleado)
        {
            Empleado entity = Convertir(empleado);
            _unidadDeTrabajo._empleadosDAL.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        public bool DeleteEmpleados(EmpleadosModel empleado)
        {
            throw new NotImplementedException();
        }

        public EmpleadosModel GetById(int id)
        {
            var entity = _unidadDeTrabajo._empleadosDAL.Get(id);

            EmpleadosModel empleadosModel = Convertir(entity);
            return empleadosModel;
        }

        public IEnumerable<EmpleadosModel> GetEmpleados()
        {
            var result = _unidadDeTrabajo._empleadosDAL.GetAll();
            List<EmpleadosModel> lista = new List<EmpleadosModel>();
            foreach (var empleado in result)
            {
                lista.Add(Convertir(empleado));
            }
            return lista;
        }

        public bool UpdateEmpleados(EmpleadosModel empleado)
        {
            throw new NotImplementedException();
        }


    }
}
