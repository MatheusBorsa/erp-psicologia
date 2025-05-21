using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules.Dtos.SearchSchedules
{
    public class SearchSchedulesInputDto
    {
        public TimeSpan? Start { get; set; }
        public TimeSpan? End { get; set; }
        public int? PatientId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public SearchSchedulesInputDto(TimeSpan? start, TimeSpan? end, int? patientId, DateTime? startDate, DateTime? endDate)
        {
            Start = start;
            End = end;
            PatientId = patientId;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
