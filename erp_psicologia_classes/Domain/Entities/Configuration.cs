using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities
{
    public class Configuration
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public Configuration(int id, string key, string value, string description)
        {
            Id = id;
            Key = key;
            Value = value;
            Description = description;
        }
    }
}
