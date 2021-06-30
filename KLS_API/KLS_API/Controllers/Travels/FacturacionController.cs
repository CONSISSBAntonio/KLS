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
        [HttpPost]
        public async Task<IActionResult> UploadFile([FromBody] Facturacion factura)
        {
            try
            {                
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion        
    }
}
