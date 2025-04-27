using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class Session
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public byte Feedback { get; set; }
        public Psychologist Psychologist { get; set; }
        public Patient Patient { get; set; }
        public Schedule Schedule { get; set; }

        public Session(string id, string description, byte feedback, Psychologist psychologist, Patient patient, Schedule schedule)
        {
            Id = id;
            Description = description;
            Feedback = feedback;
            Psychologist = psychologist;
            Patient = patient;
            Schedule = schedule;
        }

        public Session(string description, byte feedback, Psychologist psychologist, Patient patient, Schedule schedule)
        {
            Description = description;
            Feedback = feedback;
            Psychologist = psychologist;
            Patient = patient;
            Schedule = schedule;
        }
    }
}
