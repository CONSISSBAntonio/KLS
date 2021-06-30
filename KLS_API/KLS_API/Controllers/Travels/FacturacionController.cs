using KLS_API.Context;
using KLS_API.Models.Travels;
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
        public IActionResult GetAllAsync()
        {
            try
            {                
                var result =  _context.Facturacion.ToList();
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
                _context.Facturacion.Add(factura);
                _context.SaveChanges();
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
