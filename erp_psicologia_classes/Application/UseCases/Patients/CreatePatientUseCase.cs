using erp_psicologia_classes.Application.UseCases.Patients.Dtos;
using erp_psicologia_classes.Domain.Entities;
using erp_psicologia_classes.Domain.Interfaces;
using erp_psicologia_classes.Domain.ValueObjects;
using erp_psicologia_classes.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace erp_psicologia_classes.Application.UseCases.Patients
{
    public class CreatePatientUseCase : BaseUseCase,IUseCase<CreatePatientInputDto, CreatePatientOutputDto>
    {
        public CreatePatientUseCase(AppDbContext context) : base(context)
        {
        }

        public CreatePatientOutputDto Execute(CreatePatientInputDto dto)
        {
            try
            {
                Person person = new Person(
                    new Name(dto.Name),
                    dto.Description,
                    new Email(dto.Email),
                    new Phone(dto.Phone),
                    new Cpf(dto.Cpf),
                    dto.BirthDate
                );

                Context.Database.BeginTransaction();

                Context.Peoples.Add(person);
                Context.SaveChanges();

                int personId = person.Id;

                Patient patient = new Patient(personId);
                Context.Peoples.Add(person);
                Context.SaveChanges();
                Context.Database.CommitTransaction();

                return new CreatePatientOutputDto(true, "Paciente cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                Context.Database.RollbackTransaction();
                return new CreatePatientOutputDto(false, ex.Message);
            }
        }
    }
}
