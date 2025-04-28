using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(int id, Person person, Role role, string email, string password)
        {
            Id = id;
            Person = person;
            Role = role;
            Email = email;
            Password = password;
        }
    }
}
