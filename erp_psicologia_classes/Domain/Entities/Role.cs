using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAdmin { get; set; }
        public bool Active { get; set; }

        public Role(int id, string name, string description, bool isAdmin, bool active)
        {
            Id = id;
            Name = name;
            Description = description;
            IsAdmin = isAdmin;
            Active = active;
        }

        public Role(string name, string description, bool isAdmin, bool active)
        {
            Name = name;
            Description = description;
            IsAdmin = isAdmin;
            Active = active;
        }
    }
}
