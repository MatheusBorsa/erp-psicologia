using erp_psicologia_classes.Application.UseCases.Patients.Dtos;
using erp_psicologia_classes.Domain.Entities;
using erp_psicologia_classes.Domain.Interfaces;
using erp_psicologia_classes.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Patients
{
    public class SearchPatientsUseCase : BaseUseCase,IUseCase<SearchPatientInputDto, SearchPatientOutputDto>
    {
        public SearchPatientsUseCase(AppDbContext context) : base(context)
        {
        }

        public SearchPatientOutputDto Execute(SearchPatientInputDto input)
        {
            IQueryable<Patient> query = Context.Patients.AsQueryable();

            query.Where(x => x.Person.Name.Value == input.FieldBySearch);

            return new SearchPatientOutputDto(query.ToList());
        }
    }
}
