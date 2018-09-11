using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using KSS.Areas.Admin.Data;
using KSS.Areas.Admin.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;

namespace KSS
{
    public class DbSeeding
    {
        private readonly DataContext _context;

        public DbSeeding(DataContext context)
        {
            this._context = context;
        }
        public void DBSeeder()
        {
            if (_context.Users.Any())
            {
                return;
            }
            string password = "Password1234!";

            //hash and salt function
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            //creation of user
            var user = new User
            {
                FirstName = "init",
                LastName = "user",
                Phone = "5555555555",
                Email = "admin@email.com",
                Password = password,
                Salt = salt,
                Role = "Admin"
            };
        }
    }
}