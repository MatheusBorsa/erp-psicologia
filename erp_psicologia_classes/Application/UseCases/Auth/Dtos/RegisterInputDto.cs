using erp_psicologia_classes.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Auth.Dtos
{
  public class RegisterInputDto
  {
    public LicenseNumber LicenseNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public RegisterInputDto(LicenseNumber license, string email, string password)
    {
      LicenseNumber = license;
      Email = email;
      Password = password;
    }
  }
}
