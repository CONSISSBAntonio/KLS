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
        private readonly IAppContextService _appContext;
        public LoginController(IHttpClientFactory httpClientFactory, ILogger<LoginController> logger, IHttpContextAccessor httpContextAccessor, IAppContextService appContext)
        {
            util = new Util<User>(httpClientFactory);
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _appContext = appContext;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(User user)
        {
            ModelStateError modelStateError = await util.LoginAsync(Resource.RecoveryAPIUrl, user);
            var message = new Errors();
            message.ErrorMessage = "EL CORREO ELECTRÓNICO QUE INGRESASTE NO EXISTE EN NUESTRA BASE DE DATOS";

            if (modelStateError != null)
            {
                string context = Request.GetTypedHeaders().Referer.AbsoluteUri.Replace("ResetPassword", "ValidateToken");
                var link = context + "/" + modelStateError.ResetToken;

                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("account"));
                email.To.Add(MailboxAddress.Parse(user.Email));
                email.Subject = "Cambio de contraseña";
                string body = "<!DOCTYPE html> <html> <head> <link rel=\"stylesheet\" type=\"text/css\" href=\"https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons\" /> <title>Password Recovery</title> <style> body { font-family: 'Roboto', serif; font-size: 18px; font-weight: 300; } .positex { clear: both; } .float-left { float: left; } .float-right { float: right; } .borde { border-top-style: solid; border-bottom-style: solid; } .dashed { border: 1px dashed; } th { font-weight: 400; } .foot { padding-top: 50px; padding-bottom: 20px; } .foot-top { padding-top: 20px; width: 70%; } .logo { width: 150px; height: 120px; } .vertical-align { vertical-align: middle; } .text-right { text-align: right; } .text-center { text-align: center; } div span, div img { display: inline-block; vertical-align: middle; } </style> </head> <body> <div> <table width=\"100%\" bgcolor=\"#e0e0e0\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\"> <tr> <td> <table align=\"center\" width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"max-width:650px; background-color:#fff; font-family:Verdana, Geneva, sans-serif;\"> <thead> <tr height=\"80\"> <th colspan=\"4\" style=\"background-color:black; border-bottom:solid 1px #FFFFFF; font-family:Verdana, Geneva, sans-serif; color:#FFFFFF; font-size:34px;\"> CAMBIO DE CONTRASEÑA</th> </tr> </thead> <tbody> <tr> <td colspan=\"4\" style=\"padding:20px;\"> <div> <img width=\"150\" src=\"https://iili.io/R0agqX.png\" style=\"float: right;\" /> </div> </td> </tr> <tr> <td colspan=\"4\" style=\"padding:20px;\"> <p style=\"text-align: justify;\"> <b>" + string.Concat(modelStateError.Nombre, " ", modelStateError.Apaterno) + "</b> <hr /> <p style=\"text-align: justify;\"> Para crear una nueva contraseña <b><a href=\"" + link + "\">DE CLICK AQUÍ</a></b> <p> Si usted no fué quien solicitó el cambio de contraseña haga caso omiso a este mensaje. </p> </p> <p style=\"color: red;\"> No respondas a este correo electrónico, es generado por el sistema. </p> </td> </tr> </tbody> </table> </td> </tr> </table> </div> </body> </html>";
                email.Body = new TextPart(TextFormat.Html) { Text = body };

                using var smtp = new SmtpClient();
                smtp.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("email", "password");
                smtp.Send(email);
                smtp.Disconnect(true);

                message.ErrorMessage = string.Concat("EL ENLACE PARA CAMBIAR TU CONTRASEÑA FUÉ ENVIADO A: ", user.Email);
            }

            user.Errors.Add(message);
            return View(user);
        }

        public async Task<IActionResult> ValidateToken(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            PasswordReset pasword = new PasswordReset
            {
                ResetToken = id
            };

            PasswordReset validCode = await _appContext.Execute<PasswordReset>(MethodType.POST, Path.Combine("Users", "ValidToken"), pasword);

            if (validCode.IsValid)
            {
                return View("~/Views/Login/NewPassword.cshtml", validCode);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult NewPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewPassword(PasswordReset passwordReset)
        {
            if (!ModelState.IsValid)
            {
                return View(passwordReset);
            }

            var user = await _appContext.Execute<User>(MethodType.POST, Path.Combine("Users", "SetPassword"), passwordReset);

            return RedirectToAction("Login", user);
        }
    }
}
