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

namespace KLS_API.Controllers.Carriers.Contacts
{
    [Route("Carriers/Contacts")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ContactsController : Controller
    {
        private readonly AppDbContext context;
        public ContactsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult Get([FromBody] Tr_Has_Contactos tr_contactos)
        {
            try
            {
                var contactos = context.Tr_Has_Contactos.ToArray().Where(f => f.Id_Transportista == tr_contactos.Id_Transportista);
                return Ok(contactos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Tr_Has_Contactos tr_contactos)
        {
            try
            {
                context.Tr_Has_Contactos.Add(tr_contactos);
                context.SaveChanges();
                return Ok(tr_contactos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Tr_Has_Contactos tr_contactos)
        {
            try
            {
                context.Entry(tr_contactos).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(tr_contactos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
