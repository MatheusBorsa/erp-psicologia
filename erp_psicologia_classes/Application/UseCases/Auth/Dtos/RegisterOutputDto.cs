using erp_psicologia_classes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Auth.Dtos
{
  public class RegisterOutputDto
  {
    public bool Created { get; set; }
    public string Error { get; set; }

    public RegisterOutputDto(bool created, string error = "")
    {
      Created = created;
      Error = error;
    }
  }
}
