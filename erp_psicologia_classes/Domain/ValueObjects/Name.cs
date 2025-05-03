using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.ValueObjects
{
    public class Name
    {
        public string Value { get; set; }
        public Name(string value) 
        {
            ValidateName(value);
            Value = value;

        
        }
        private void ValidateName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value");
            }
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
