using erp_psicologia_classes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Auth.Dtos
{
    public class LoginOutputDto
    {
        public bool Logged { get; set; }
        public string Error { get; set; }
        public Psychologist Psychologist { get; set; }

        public LoginOutputDto(bool logged, string error = "")
        {
            Logged = logged;
            Error = error;
        }

    }
}
