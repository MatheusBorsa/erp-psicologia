using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules.Dtos.VerifyAvaliableTime
{
    public class VerifyAvaliableTimeOutputDto
    {
        public bool Avaliable { get; set; }

        public VerifyAvaliableTimeOutputDto(bool avaliable)
        {
            Avaliable = avaliable;
        }
    }
}
