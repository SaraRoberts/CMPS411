using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using KSS.Areas.Admin.Data;
using KSS.Areas.Admin.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KSS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly DataContext _context;

        public int Id { get; set; }

        public AccountController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Welcome));
        }
        [Authorize(Roles = "Admin")]
        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public async Task<IActionResult> Welcome()
        {
            var dataContext = _context
                .Instance.Include(i => i.Course)
                .Include(i => i.Location)
                .Where(e => e.StartDate >= DateTime.UtcNow)
                .OrderBy(e => e.StartDate);
            return View(await dataContext.ToListAsync());
        }
        public IActionResult AccessDenied()
        {

            return View();

        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Login(User vm)
        {
            var user = await _context.Users.SingleOrDefaultAsync(m => m.Email == vm.Email);
            if (user != null && ModelState.IsValid)
            {
                //password is hashed
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: vm.Password,
                    salt: user.Salt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));
                //-------hash function end

                if (user.Password == hashed)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.FirstName),
                        new Claim(ClaimTypes.Role, user.Role)
                    };

                    var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        //AllowRefresh = <bool>,
                        // Refreshing the authentication session should be allowed.

                        //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                        // The time at which the authentication ticket expires. A 
                        // value set here overrides the ExpireTimeSpan option of 
                        // CookieAuthenticationOptions set with AddCookie.

                        //IsPersistent = true,
                        // Whether the authentication session is persisted across 
                        // multiple requests. Required when setting the 
                        // ExpireTimeSpan option of CookieAuthenticationOptions 
                        // set with AddCookie. Also required when setting 
                        // ExpiresUtc.

                        //IssuedUtc = <DateTimeOffset>,
                        // The time at which the authentication ticket was issued.

                        //RedirectUri = <string>
                        // The full path or absolute URI to be used as an http 
                        // redirect response value.
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return RedirectToAction(nameof(Welcome));
                }
            }
            ViewData["Error"] = "ERROR";
            return View();

        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));

        }
    }
}