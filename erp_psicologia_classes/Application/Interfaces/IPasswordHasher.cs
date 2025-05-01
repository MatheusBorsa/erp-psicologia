using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.Interfaces
{
    public interface IPasswordHasher
    {
        public string Hash(string password);
        public bool VerifyPassword(string password,string hash);
    }
}
