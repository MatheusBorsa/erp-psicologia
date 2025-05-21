using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules.Dtos.DeleteSchedule
{
    public class DeleteScheduleOutputDto
    {
        public string Result { get; set; }
        public bool Error { get; set; }

        public DeleteScheduleOutputDto(string result, bool error = false)
        {
            Result = result;
            Error = error;
        }
    }
}
