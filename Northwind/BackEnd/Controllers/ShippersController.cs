using BackEnd.Models;
using BackEnd.Services.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippersController : ControllerBase
    {
        IShippersService ShippersService;
        public ShippersController(IShippersService shippersService)
        {
            ShippersService = shippersService;
        }

        // GET: api/<ShippersController>
        [HttpGet]
        public IEnumerable<ShippersModel> Get()
        {
            return ShippersService.GetShippers();
        }

        // GET api/<ShippersController>/5
        [HttpGet("{id}")]
        public ShippersModel Get(int id)
        {
            return ShippersService.GetById(id);
        }

        // POST api/<ShippersController>
        [HttpPost]
        public string Post([FromBody] ShippersModel shippers)
        {
            var result = ShippersService.AddShippers(shippers);

            if (result)
            {
                return "Shipper agregado correctamente.";
            }

                return "Hubo un error al agregar la entidad.";
        }

        // PUT api/<ShippersController>/5
        [HttpPut]
        public string Put(int id, [FromBody] ShippersModel shippers)
        {
            var result = ShippersService.UpdateShippers(shippers);

            if (result)
            {
                return "Shipper actualizado correctamente.";
            }

                return "Hubo un error al actualizar la entidad.";
        }

        // DELETE api/<ShippersController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            ShippersModel shippers = new ShippersModel { ShipperId = id };

            var result = ShippersService.DeleteShippers(shippers);

            if (result)
            {
                return "Shipper eliminado correctamente.";
            }

            return "Hubo un error al eliminar la entidad.";
        }
    }
}
