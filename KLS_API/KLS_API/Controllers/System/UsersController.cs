using KLS_API.Context;
using KLS_API.Models;
using KLS_API.Models.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KLS_API.Controllers.System
{
    [Route("Users")]
    public class UsersController : Controller
    {
        private readonly UserManager<AddUser> userManager;
        private readonly SignInManager<AddUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;
        private readonly AppDbContext context;
        public UsersController(UserManager<AddUser> userManager,SignInManager<AddUser> signInManager,RoleManager<IdentityRole> roleManager,IHttpClientFactory httpClientFactory,IConfiguration configuration, AppDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
            this.context = context;
        }

        public async Task<ActionResult> ListUsersAsync()
        {
            var users = userManager.Users.ToList();
            List<UserDTO> parts = new List<UserDTO>();
            foreach (var user in users)
            {
                var rol = await userManager.GetRolesAsync(user);
                foreach (var roles in rol)
                {
                    parts.Add(new UserDTO() { 
                        Nombre = user.Nombre,
                        Apaterno = user.Apaterno,
                        Amaterno = user.Amaterno,
                        Email = user.Email,
                        Id_User = user.Id,
                        Rol = roles.ToString(),
                        activo = user.activo
                    });
                }
            }
            return Ok(parts);
        }
        
        //[HttpPost]
        //public async Task<ActionResult> ListUsersAsync()
        //{
        //    var users = userManager.Users.ToList();
        //    List<UserDTO> parts = new List<UserDTO>();
        //    foreach (var user in users)
        //    {
        //        var rol = await userManager.GetRolesAsync(user);
        //        foreach (var roles in rol)
        //        {
        //            parts.Add(new UserDTO() { 
        //                Nombre = user.Nombre,
        //                Apaterno = user.Apaterno,
        //                Amaterno = user.Amaterno,
        //                Email = user.Email,
        //                Id_User = user.Id,
        //                Rol = roles.ToString(),
        //                activo = user.activo
        //            });
        //        }
        //    }
        //    return Ok(parts);
        //}



        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
        {
            var user = new AddUser { UserName = userDTO.Email, Email = userDTO.Email, Apaterno = userDTO.Apaterno, Nombre = userDTO.Nombre, Amaterno = userDTO.Amaterno };

            var result = await userManager.CreateAsync(user, userDTO.Password);

            if (result.Succeeded)
            {
                if (!await roleManager.RoleExistsAsync(userDTO.Rol))
                {
                    await roleManager.CreateAsync(new IdentityRole(userDTO.Rol));
                }

                if (!await roleManager.RoleExistsAsync("Customer"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Customer"));
                }
                await userManager.AddToRoleAsync(user, userDTO.Rol);
                return NoContent();
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("Response", item.Description);
            }

            return Ok(ModelState);
        }
        
        [HttpPost("Login")]
        public async Task<ActionResult<UserTokenDTO>> Login([FromBody] UserDTO userDTO)
        {
            var result = await signInManager.PasswordSignInAsync(userDTO.Email, userDTO.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                
                var user = await userManager.FindByEmailAsync(userDTO.Email);
                var roles = await userManager.GetRolesAsync(user);
                var token = CreateToken(user, roles);
                
                return new UserTokenDTO
                {
                    Token = token,
                    UserName = user.UserName,
                    Roles = roles,
                    Id = user.Id,
                    Nombre = user.Nombre,
                    Apaterno = user.Apaterno,
                    Amaterno = user.Amaterno,
                };
            }
            ModelState.AddModelError("Response", "Nombre de usuario/contraseña no válido");
            return StatusCode(400, ModelState);
        }

        private string CreateToken(AddUser user, IList<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            foreach (var rolName in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, rolName));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = creds
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
