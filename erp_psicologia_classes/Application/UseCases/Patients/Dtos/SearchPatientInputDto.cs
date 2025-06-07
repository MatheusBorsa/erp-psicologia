using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Patients.Dtos
{
    public class SearchPatientInputDto
    {
        public string FieldBySearch {  get; set; }

        public SearchPatientInputDto(string fieldBySearch)
        {
            FieldBySearch = fieldBySearch;
        }
    }
}
