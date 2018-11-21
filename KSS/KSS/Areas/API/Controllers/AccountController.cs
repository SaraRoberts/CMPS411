using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using KSS.Areas.Admin.Data;
using KSS.Areas.Admin.Models;
using KSS.Areas.API.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KSS.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly DataContext _context;

        public AccountController(DataContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [Route("Register")]
        [HttpPost]
        public IActionResult Register([FromBody] RegisterApi register)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            //--register.password is hashed
            var users = _context.Users;
            var userFound = users.SingleOrDefault(u => u.Email.Equals(register.Email));
            if (userFound != null)
                return Forbid();

            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: register.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            //-------hash function end

            users.Add(new User()
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Phone = register.Phone,
                Email = register.Email,
                Password = hashedPassword,
                Salt = salt,
                Role = "User"
            });
            _context.SaveChanges();
            return Ok();
        }

        [AllowAnonymous]
        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginApi login)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = _context.Users.SingleOrDefault(u => u.Email == login.Email);

            if (user == null)
                return NotFound();

            //login.password is hashed
            string loginHashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: login.Password,
                salt: user.Salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            //-------hash function end

            if (loginHashed != user.Password)
            {
                return Forbid();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Role, user.Role),
                new Claim("FullName", user.FirstName+" "+user.LastName)
            };
            var claimsIdentity = new ClaimsIdentity(
            claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));
            return Ok();
        }

        [Route("Logout")]
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);

            return Ok();
        }
    }
}