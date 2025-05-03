using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.ValueObjects
{
    public class LicenseNumber
    {
        public string Value;
        public LicenseNumber(string value)
        {
            ValidateLicenseNumber(value);
            this.Value = value;
        }
        private void ValidateLicenseNumber(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Licença inválida");
            }
            if(!int.TryParse(value,out _))
            {
                throw new ArgumentException("Licença inválida");

            }
        }
        public override string ToString()
        {
            return Value;
        }

    }
}
