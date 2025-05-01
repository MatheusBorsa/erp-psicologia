using erp_psicologia_classes.Domain.Enums;
using erp_psicologia_classes.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class Psychologist
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public LicenseNumber LicenseNumber { get; set; }
        public ApproachType Approach { get; set; }
        public string Password { get; set; }

        public Psychologist()
        {
        }

        public Psychologist(int id, int personId, LicenseNumber licenseNumber, ApproachType approach, string password)
        {
            Id = id;
            PersonId = personId;
            LicenseNumber = licenseNumber;
            Approach = approach;
            Password = password;
        }
    }
}
