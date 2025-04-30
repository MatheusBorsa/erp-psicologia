using erp_psicologia_classes.Application.UseCases.Patient.Dtos;
using erp_psicologia_classes.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Patient
{
    public class CreatePatientUseCase : IUseCase<CreatePatientInputDto, CreatePatientOutputDto>
    {
        public CreatePatientOutputDto Execute(CreatePatientInputDto dto)
        {
            return new CreatePatientOutputDto();
        }
    }
}
