using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }

        public int PsychologistId { get; set; }
        public Psychologist Psychologist { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public virtual Session Session { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Schedule()
        {
        }

        public Schedule(int id, DateTime date, TimeSpan start, TimeSpan end, int psychologistId, int patientId)
        {
            Id = id;
            Date = date;
            Start = start;
            End = end;
            PsychologistId = psychologistId;
            PatientId = patientId;
        }

        public Schedule(DateTime date, TimeSpan start, TimeSpan end, int psychologistId, int patientId)
        {
            Date = date;
            Start = start;
            End = end;
            PsychologistId = psychologistId;
            PatientId = patientId;
        }
    }
}
