using BackEnd.Models;
using BackEnd.Services.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmpleadosService _empleadosService;

        public EmpleadosController(IEmpleadosService empleadosService)
        {
            _empleadosService = empleadosService;
        }

        [HttpGet]
        public IEnumerable<EmpleadosModel> Get()
        {
            return _empleadosService.GetEmpleados();
        }

        [HttpGet("{id}")]
        public ActionResult<EmpleadosModel> Get(int id)
        {
            var empleado = _empleadosService.GetById(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return empleado;
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] EmpleadosModel empleado)
        {
            var result = _empleadosService.AddEmpleados(empleado);

            if (result)
            {
                return "Empleado agregado correctamente.";
            }

            return BadRequest("Hubo un error al agregar el empleado.");
        }

        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] EmpleadosModel empleado)
        {
            empleado.EmpleadoId = id;
            var result = _empleadosService.UpdateEmpleados(empleado);

            if (result)
            {
                return "Empleado actualizado correctamente.";
            }

            return BadRequest("Hubo un error al actualizar el empleado.");
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            var empleado = new EmpleadosModel { EmpleadoId = id };

            var result = _empleadosService.DeleteEmpleados(empleado);

            if (result)
            {
                return "Empleado eliminado correctamente.";
            }

            return BadRequest("Hubo un error al eliminar el empleado.");
        }
    }
}
