using erp_psicologia_classes.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public string Description { get; set; }
        public Email Email { get; set; }
        public Phone Phone { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(int id, Name name, string description, Email email, Phone phone, Cpf cpf, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Email = email;
            Phone = phone;
            Cpf = cpf;
            BirthDate = birthDate;
        }

        public Person(Name name, string description, Email email, Phone phone, Cpf cpf, DateTime birthDate)
        {
            Name = name;
            Description = description;
            Email = email;
            Phone = phone;
            Cpf = cpf;
            BirthDate = birthDate;
        }

        public Person(){}
    }
}
