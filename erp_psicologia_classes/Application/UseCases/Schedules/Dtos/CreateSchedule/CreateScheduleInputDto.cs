using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules.Dtos.CreateSchedule
{
    public class CreateScheduleInputDto
    {
        public DateTime Date { get; private set; }
        public TimeSpan Start { get; private set; }
        public TimeSpan End { get; private set; }
        public int PsychologistId { get; private set; }
        public int PatientId { get; private set; }

        public CreateScheduleInputDto(DateTime date, TimeSpan start, int psychologistId, int patientId)
        {
            Date = date;
            Start = start;
            PsychologistId = psychologistId;
            PatientId = patientId;
        }

        public CreateScheduleInputDto(DateTime date, TimeSpan start, TimeSpan end, int psychologistId, int patientId)
        {
            Date = date;
            Start = start;
            End = end;
            PsychologistId = psychologistId;
            PatientId = patientId;
        }
    }
}
