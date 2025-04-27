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
        public Psychologist Psychologist { get; set; }
        public Patient Patient { get; set; }

        public Schedule(int id, DateTime date, TimeSpan start, TimeSpan end, Psychologist psychologist, Patient patient)
        {
            Id = id;
            Date = date;
            Start = start;
            End = end;
            Psychologist = psychologist;
            Patient = patient;
        }

        public Schedule(DateTime date, TimeSpan start, TimeSpan end, Psychologist psychologist, Patient patient)
        {
            Date = date;
            Start = start;
            End = end;
            Psychologist = psychologist;
            Patient = patient;
        }
    }
}
