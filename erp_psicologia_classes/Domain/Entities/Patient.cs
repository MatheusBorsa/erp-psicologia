using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }         
        public int PersonId { get; set; }    
        public Person Person { get; set; }

        public Patient(int id, int personId)
        {
            Id = id;
            PersonId = personId;
        }

        public Patient(int personId)
        {
            PersonId = personId;
        }

        protected Patient() { }
    }
}
