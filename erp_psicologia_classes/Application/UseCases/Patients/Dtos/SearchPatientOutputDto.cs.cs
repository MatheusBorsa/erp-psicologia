using erp_psicologia_classes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Patients.Dtos
{
    public class SearchPatientOutputDto
    {
        public List<Patient> Patients { get; set; }
        public SearchPatientOutputDto(List<Patient> patients) { 
            this.Patients = patients;
        }
    }
}
