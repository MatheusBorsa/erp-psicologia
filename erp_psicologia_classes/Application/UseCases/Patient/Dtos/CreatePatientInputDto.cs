using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Patient.Dtos
{
    public class CreatePatientInputDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email {  get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }

        public CreatePatientInputDto(string name, string description, string email, string phone, string cpf, DateTime birthDate)
        {
            Name = name;
            Description = description;
            Email = email;
            Phone = phone;
            Cpf = cpf;
            BirthDate = birthDate;
        }

        public CreatePatientInputDto(string name, string description, string email, string phone, string cpf)
        {
            Name = name;
            Description = description;
            Email = email;
            Phone = phone;
            Cpf = cpf;
        }
    }
}
