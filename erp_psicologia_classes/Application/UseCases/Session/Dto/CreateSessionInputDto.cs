using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Session.Dto
{
    public class CreateSessionInputDto
    {
        public string Description { get; set; }
        public string Feedback {  get; set; }
        public int PsychologistId { get; set; }
        public int PatientId { get; set; }
    }
}
