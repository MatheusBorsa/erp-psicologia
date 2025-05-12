using erp_psicologia_classes.Application.Dtos;
using erp_psicologia_classes.Application.Interfaces;
using erp_psicologia_classes.Application.UseCases.Auth.Dtos;
using erp_psicologia_classes.Domain.Entities;
using erp_psicologia_classes.Domain.Interfaces;
using erp_psicologia_classes.Domain.ValueObjects;
using erp_psicologia_classes.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace erp_psicologia_classes.Application.UseCases.Auth
{
    public class RegisterUseCase : BaseUseCase, IUseCase<RegisterInputDto, RegisterOutputDto>
    {
        private readonly IPasswordHasher _hasher;
        
        public RegisterUseCase(AppDbContext context, IPasswordHasher hasher) 
            : base(context)
        {
            _hasher = hasher;
        }

        public RegisterOutputDto Execute(RegisterInputDto input)
        {
            Email email = new Email(input.Email);

            Psychologist? existingPsychologist = Context.Psychologists
                .Include(p => p.Person)
                .FirstOrDefault(p => p.LicenseNumber.Value == input.LicenseNumber.Value);

            if (existingPsychologist != null)
            {
                return new RegisterOutputDto(false, "Número de licença já cadastrado");
            }

            // Check email uniqueness
            if (Context.Psychologists
                .Include(p => p.Person)
                .Any(p => p.Person.Email.Value == input.Email))
            {
                return new RegisterOutputDto(false, "E-mail já cadastrado");
            }

            // Create new psychologist
            Psychologist psychologist = new Psychologist
            {
                LicenseNumber = input.LicenseNumber,
                Password = _hasher.Hash(input.Password),
                Person = new Person
                {
                    Email = email
                }
            };

            Context.Psychologists.Add(psychologist);
            Context.SaveChanges();

            return new RegisterOutputDto(true, "Registro realizado com sucesso");
        }
    }
}
