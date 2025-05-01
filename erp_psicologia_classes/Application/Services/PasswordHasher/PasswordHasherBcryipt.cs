using erp_psicologia_classes.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.Services.PasswordHasher
{
    public class PasswordHasherBcryipt : IPasswordHasher
    {
        // testeaaaaaaaaaaaaaaaaaaaaaa
        public string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password,string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
