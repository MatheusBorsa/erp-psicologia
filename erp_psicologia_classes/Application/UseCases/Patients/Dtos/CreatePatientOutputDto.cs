using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Patients.Dtos
{
    public class CreatePatientOutputDto
    {
        public string Error { get; set; }

        public bool Created {  get; set; }



        public CreatePatientOutputDto(bool created, string error = "")
        {
            Created = created;
            Error = error;
        }
    }
}
