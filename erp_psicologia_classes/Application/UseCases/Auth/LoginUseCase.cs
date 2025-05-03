using erp_psicologia_classes.Application.Dtos;
using erp_psicologia_classes.Application.Interfaces;
using erp_psicologia_classes.Application.UseCases.Auth.Dtos;
using erp_psicologia_classes.Domain.Entities;
using erp_psicologia_classes.Domain.Interfaces;
using erp_psicologia_classes.Domain.ValueObjects;
using erp_psicologia_classes.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Auth
{
    public class LoginUseCase : BaseUseCase,IUseCase<LoginInputDto, LoginOutputDto>
    {
        IPasswordHasher Hasher { get; set; }
        public LoginUseCase(AppDbContext context,IPasswordHasher hasher) : base(context)
        {
            Hasher = hasher;
        }
        public LoginOutputDto Execute(LoginInputDto input)
        {
            Psychologist? psychologist = null;
            psychologist = Context.Psychologists.FirstOrDefault(
                p => p.LicenseNumber.Value == input.LicenseNumber.Value
            );

            if (psychologist == null || !Hasher.VerifyPassword(input.Password, psychologist.Password)) {
                return new LoginOutputDto(false, "Usuário ou senha não encontrados");
            }
            return new LoginOutputDto(true);
        }
    }
}
