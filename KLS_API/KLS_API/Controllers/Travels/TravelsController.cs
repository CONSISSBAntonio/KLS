using KLS_API.Context;
using KLS_API.Models.Travels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpPost]
        public IActionResult Post([FromBody] Travel travel)
        {
            return Ok(travel);
        }
    }
}
