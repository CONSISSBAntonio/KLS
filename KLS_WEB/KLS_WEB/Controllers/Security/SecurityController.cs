using KLS_API.Models.DTO;
using KLS_WEB.Models;
using KLS_WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.Security
{
    [Route("Security")]
    [Authorize]
    public class SecurityController : Controller
    {
        private string _UrlView = "~/Views/Security/";
        private string _UrlApi = "Users/Register";

        private readonly IAppContextService AppContext;
        public SecurityController(IAppContextService _AppContext)
        {
            this.AppContext = _AppContext;
        }

        public IActionResult Index()
        {
            return View(this._UrlView + "index.cshtml");
        }

        [Route("getSecurity")]
        public async Task<JsonResult> Get(UserDTO dataModel)
        {
            List<UserDTO> dataReport;
            dataReport = await this.AppContext.Execute<List<UserDTO>>(MethodType.GET, "Users", dataModel);
            return Json(dataReport);
        }

        [HttpPost]
        [Route("setSecurity")]
        public async Task<JsonResult> Post(UserDTO dataModel)
        {
            UserDTO dataReport;
            dataReport = await this.AppContext.Execute<UserDTO>(MethodType.POST, _UrlApi, dataModel);
            return Json(dataReport);
        }
    }
}
