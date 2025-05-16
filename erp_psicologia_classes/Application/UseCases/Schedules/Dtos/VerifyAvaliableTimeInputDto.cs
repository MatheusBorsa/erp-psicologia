using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules.Dtos
{
    public class VerifyAvaliableTimeInputDto
    {
        public DateTime Date { get; private set; }
        public TimeSpan Start { get; private set; }
        public TimeSpan End { get; private set; }

        public VerifyAvaliableTimeInputDto(DateTime date, TimeSpan start, TimeSpan end)
        {
            Date = date;
            Start = start;
            End = end;
        }
    }
}
