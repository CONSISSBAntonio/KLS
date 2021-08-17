using KLS_WEB.Models;
using KLS_WEB.Services;
using KLS_WEB.Utility;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KLS_WEB.Controllers.System
{
    public class LoginController : Controller
    {
        private readonly Util<User> util;
        private readonly ILogger<LoginController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LoginController(IHttpClientFactory httpClientFactory, ILogger<LoginController> logger, IHttpContextAccessor httpContextAccessor)
        {
            util = new Util<User>(httpClientFactory);
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Login()
        {
            return View(new User());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user)
        {
            if (ModelState.IsValid)
            {
                var modelStateError = await util.LoginAsync(Resource.LoginAPIUrl, user);

                if (modelStateError.Response.Errors.Count > 0)
                {
                    foreach (var item in modelStateError.Response.Errors)
                    {
                        user.Errors.Add(item);
                    }
                    return View(user);
                }

                if (modelStateError.Token is null) return View(user);

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, modelStateError.UserName));

                foreach (var rolName in modelStateError.Roles)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, rolName));
                }

                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                HttpContext.Session.SetString("Token", modelStateError.Token);
                HttpContext.Session.SetString("UserName", modelStateError.UserName);
                HttpContext.Session.SetString("Nombre", modelStateError.Nombre);
                HttpContext.Session.SetString("Apaterno", modelStateError.Apaterno);
                HttpContext.Session.SetString("Amaterno", modelStateError.Amaterno);
                HttpContext.Session.SetString("Id", modelStateError.Id);
                HttpContext.Session.SetString("UserFN", string.Concat(modelStateError.Nombre, " ", modelStateError.Apaterno));
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

        //Registrar usuario
        public IActionResult Register()
        {
            return View(new User());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                var modelStateError = await util.RegisterAsync(Resource.RegisterAPIUrl, user);

                if (modelStateError.Response.Errors.Count > 0)
                {
                    foreach (var item in modelStateError.Response.Errors)
                    {
                        user.Errors.Add(item);
                    }
                    return View(user);
                }

                return RedirectToAction(nameof(Login));
            }
            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.SetString("Token", string.Empty);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ResetPassword(User user)
        //{
        //    ModelStateError modelStateError = await util.LoginAsync(Resource.RecoveryAPIUrl, user);

        //    if (modelStateError.Nombre != null)
        //    {
        //        string context = Request.GetTypedHeaders().Referer.AbsoluteUri;
        //        var link = context + modelStateError.Token;
        //        //var link = Path.Combine(_appContext, "owkeq");
        //        //var link = Path.Combine(context, "/Login/ResetPassword/", modelStateError.Token);

        //        var email = new MimeMessage();
        //        email.From.Add(MailboxAddress.Parse("itmh@matehuala.tecnm.mx"));
        //        email.To.Add(MailboxAddress.Parse(user.Email));
        //        email.Subject = "Test Email Subject";
        //        email.Body = new TextPart(TextFormat.Html) { Text = string.Concat(@"<h1>Recupera tu contraesña da click en el siguiente enlace</h1><a href=", link, @">RECUPERAR CONTRASEÑA</a>") };

        //        // send email
        //        using var smtp = new SmtpClient();
        //        smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
        //        smtp.Authenticate("itmh@matehuala.tecnm.mx", "Mypassw0rd");
        //        smtp.Send(email);
        //        smtp.Disconnect(true);

        //        var message = new Errors
        //        {
        //            ErrorMessage = modelStateError.Nombre
        //        };

        //        user.Errors.Add(message);
        //        return View(user);
        //    }
        //    return View(user);
        //}
    }
}
