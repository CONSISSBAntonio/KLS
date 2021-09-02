using KLS_API.Context;
using KLS_API.Models.Travel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Controllers.Travels
{
    [Route("Travels/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class FacturacionController : ControllerBase
    {
        #region Properties
        private readonly AppDbContext _context;
        #endregion

        #region Constructor
        public FacturacionController(AppDbContext context)
        {
            _context = context; 
        }
        #endregion

        #region Methods
        [HttpGet]
        public IActionResult GetAllAsync([FromBody] Facturacion facturacion)
        {
            try
            {                
                var result =  _context.Facturacion.Where(x => x.SectionId == facturacion.SectionId).ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile([FromBody] Facturacion factura)
        {
            try
            {
                await _context.Facturacion.AddAsync(factura);
                await _context.SaveChangesAsync();
                return Ok(factura);                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion        
    }
}
