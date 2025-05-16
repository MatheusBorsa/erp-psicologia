using erp_psicologia_classes.Application.UseCases.Schedules.Dtos;
using erp_psicologia_classes.Domain.Entities;
using erp_psicologia_classes.Domain.Interfaces;
using erp_psicologia_classes.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules
{
    public class VerifyAvaliableTimeUseCase : IUseCase<VerifyAvaliableTimeInputDto, VerifyAvaliableTimeOutputDto>
    {
        private AppDbContext DbContext { get; set; }
        public VerifyAvaliableTimeUseCase(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public VerifyAvaliableTimeOutputDto Execute(VerifyAvaliableTimeInputDto input)
        {
            Schedule? schedule = null;
            schedule = DbContext.Schedules.FirstOrDefault(
                x => 
                    x.Start == input.Start &&
                    x.End == input.End &&
                    x.Date == input.Date
            );
            return schedule != null ?
                new VerifyAvaliableTimeOutputDto(true) :
                new VerifyAvaliableTimeOutputDto(false);   
        }
    }
}
