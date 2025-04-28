using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class Session
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public byte Feedback { get; set; }

        public int PsychologistId { get; set; }
        public Psychologist Psychologist { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }

        public Session()
        {
        }

        public Session(int id, string description, byte feedback, int psychologistId, int patientId, int scheduleId, Schedule schedule)
        {
            Id = id;
            Description = description;
            Feedback = feedback;
            PsychologistId = psychologistId;
            PatientId = patientId;
            ScheduleId = scheduleId;
            Schedule = schedule;
        }
    }
}
