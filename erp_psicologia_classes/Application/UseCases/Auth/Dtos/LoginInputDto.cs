using erp_psicologia_classes.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Auth.Dtos
{
    public class LoginInputDto
    {
        public LicenseNumber LicenseNumber {  get; set; }
        public string Password { get; set; }

        public LoginInputDto(LicenseNumber license, string password)
        {
            LicenseNumber = license;
            Password = password;
        }
    }
}
