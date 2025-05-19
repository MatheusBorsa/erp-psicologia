using erp_psicologia_classes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules.Dtos
{
    public class SearchSchedulesOutputDto
    {
        public List<Schedule> Schedules { get; set; }

        public SearchSchedulesOutputDto(List<Schedule> schedules)
        {
            Schedules = schedules;
        }
    }
}
