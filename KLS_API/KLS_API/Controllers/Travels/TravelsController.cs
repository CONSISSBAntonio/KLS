using KLS_API.Context;
using KLS_API.Models.Travels;
using Microsoft.AspNetCore.Mvc;
using KLS_API.Models.DTO;
using System;
using System.Linq;

namespace KLS_API.Controllers.Travels
{
    [Route("[controller]")]
    public class TravelsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public TravelsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetTravels()
        {
            try
            {
                //var dt = from viajes in _dbContext.Viajes
                //         join cliente in _dbContext.Clientes on viajes.IdCliente equals cliente.id
                //         join ciudad in _dbContext.Cat_Ciudad on viajes.IdOrigen equals ciudad.id
                //         join 
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Travel travel)
        {
            try
            {
                _dbContext.Viajes.Add(travel);
                _dbContext.SaveChanges();
                return Ok(travel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("[action]")]
        public IActionResult PostService([FromBody] Services service)
        {
            try
            {
                _dbContext.Servicios.Add(service);
                _dbContext.SaveChanges();
                return Ok(service);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("[action]")]
        public IActionResult PostUnit([FromBody] Unidad unidad)
        {
            try
            {
                _dbContext.Unidades.Add(unidad);
                _dbContext.SaveChanges();
                return Ok(unidad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
