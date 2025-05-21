using erp_psicologia_classes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules.Dtos.DeleteSchedule
{
    public class DeleteScheduleInputDto
    {
        public int ScheduleId { get; set; }

        public DeleteScheduleInputDto(int scheduleId)
        {
            ScheduleId = scheduleId;
        }
    }
}
