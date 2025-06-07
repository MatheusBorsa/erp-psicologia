using erp_psicologia_classes.Application.UseCases.Schedules.Dtos.CreateSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Sessions.Dto.CreateSession
{
    public class CreateSessionInputDto
    {
        public CreateScheduleInputDto CreateScheduleInputDto { get; set; }

        public CreateSessionInputDto(CreateScheduleInputDto createScheduleInputDto)
        {
            CreateScheduleInputDto = createScheduleInputDto;
        }
    }
}
