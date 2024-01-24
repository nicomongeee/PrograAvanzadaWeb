using BackEnd.Models;
using BackEnd.Services.Interfaces;
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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShippersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShippersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
