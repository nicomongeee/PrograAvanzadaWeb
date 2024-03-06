using BackEnd.Models;
using BackEnd.Services.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritosController : ControllerBase
    {
        IDistritosService DistritosService;
        public DistritosController(IDistritosService distritosService)
        {
            DistritosService = distritosService;
        }

        // GET: api/<DistritosController>
        [HttpGet]
        public IEnumerable<DistritosModel> Get()
        {
            return DistritosService.GetDistritos();
        }

        // GET api/<DistritosController>/5
        [HttpGet("{id}")]
        public DistritosModel Get(int id)
        {
            return DistritosService.GetById(id);
        }

        // POST api/<DistritosController>
        [HttpPost]
        public string Post([FromBody] DistritosModel distritos)
        {
            var result = DistritosService.AddDistritos(distritos);

            if (result)
            {
                return "Distrito agregado correctamente.";
            }

                return "Hubo un error al agregar la entidad.";
        }

        // PUT api/<DistritosController>/5
        [HttpPut]
        public string Put(int id, [FromBody] DistritosModel distritos)
        {
            var result = DistritosService.UpdateDistritos(distritos);

            if (result)
            {
                return "Distrito actualizado correctamente.";
            }

                return "Hubo un error al actualizar la entidad.";
        }

        // DELETE api/<DistritosController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            DistritosModel distritos = new DistritosModel { DistritoId = id };

            var result = DistritosService.DeleteDistritos(distritos);

            if (result)
            {
                return "Distrito eliminado correctamente.";
            }

            return "Hubo un error al eliminar la entidad.";
        }
    }
}
