using KLS_API.Context;
using KLS_API.Models.Carriers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Carriers.Library
{
    [Route("Carriers/Library")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class LibraryController : Controller
    {
        private readonly AppDbContext context;
        public LibraryController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get([FromBody] Tr_Has_Biblioteca tr_libreria)
        {
            try
            {
                var Box = context.Tr_Has_Biblioteca.ToArray().Where(f => f.Id_Transportista == tr_libreria.Id_Transportista);
                return Ok(Box);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Tr_Has_Biblioteca tr_biblioteca)
        {
            try
            {
                context.Tr_Has_Biblioteca.Add(tr_biblioteca);
                context.SaveChanges();
                return Ok(tr_biblioteca);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Tr_Has_Biblioteca tr_biblioteca)
        {
            try
            {
                context.Entry(tr_biblioteca).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_biblioteca);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
