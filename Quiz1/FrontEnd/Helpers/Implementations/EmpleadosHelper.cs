using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using FrontEnd.ApiModels;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementations
{
    public class EmpleadosHelper : IEmpleadosHelper
    {
        IServiceRepository ServiceRepository;

        public EmpleadosHelper(IServiceRepository serviceRepository)
        {
            ServiceRepository = serviceRepository;
        }

        public EmpleadosViewModel AddEmpleados(EmpleadosViewModel empleado)
        {
            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/empleados", Convertir(empleado));
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                //var empleadoAPI = JsonConvert.DeserializeObject<EmpleadosViewModel>(content);
            }
            return empleado;
        }

        EmpleadosViewModel Convertir(Empleados empleado)
        {
            return new EmpleadosViewModel
            {
                EmpleadoId = empleado.EmpleadoId,
                Nombre = empleado.Nombre,
                Salario = empleado.Salario
            };
        }

        Empleados Convertir(EmpleadosViewModel empleado)
        {
            return new Empleados
            {
                EmpleadoId = empleado.EmpleadoId,
                Nombre = empleado.Nombre,
                Salario = empleado.Salario
            };
        }

        public EmpleadosViewModel DeleteEmpleados(int id)
        {
            HttpResponseMessage responseMessage = ServiceRepository.DeleteResponse("api/empleados/" + id.ToString());
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
            }
            return new EmpleadosViewModel();
        }

        public EmpleadosViewModel GetAll()
        {
            throw new NotImplementedException();
        }

        public List<EmpleadosViewModel> GetEmpleados()
        {
            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/empleados");
            List<Empleados> empleados = new List<Empleados>();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                empleados = JsonConvert.DeserializeObject<List<Empleados>>(content);
            }
            List<EmpleadosViewModel> lista = new List<EmpleadosViewModel>();
            if (empleados != null && empleados.Count > 0)
            {
                foreach (var item in empleados)
                {
                    lista.Add(Convertir(item));
                }
            }
            return lista;
        }

        public EmpleadosViewModel GetEmpleados(int id)
        {
            EmpleadosViewModel empleado = new EmpleadosViewModel();
            HttpResponseMessage responseMessage = ServiceRepository.GetResponse("api/empleados/" + id.ToString());
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                empleado = Convertir(JsonConvert.DeserializeObject<Empleados>(content));
            }
            return empleado;
        }

        public EmpleadosViewModel UpdateEmpleados(EmpleadosViewModel empleado)
        {
            HttpResponseMessage responseMessage = ServiceRepository.PutResponse("api/empleados", Convertir(empleado));
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                //var empleadoAPI = JsonConvert.DeserializeObject<Empleado>(content);
            }
            return empleado;
        }

        
    }
}
