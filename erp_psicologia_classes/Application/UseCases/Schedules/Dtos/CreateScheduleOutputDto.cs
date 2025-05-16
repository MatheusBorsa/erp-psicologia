using erp_psicologia_classes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules.Dtos
{
    public class CreateScheduleOutputDto
    {
        public string Error { get; set; }

        public bool Created { get; set; }
        public Schedule Schedule { get; set; }



        public CreateScheduleOutputDto(bool created, string error = "")
        {
            Created = created;
            Error = error;
        }

        public CreateScheduleOutputDto(bool created, Schedule schedule, string error = "")
        {
            Error = error;
            Created = created;
            Schedule = schedule;
        }
    }
}
