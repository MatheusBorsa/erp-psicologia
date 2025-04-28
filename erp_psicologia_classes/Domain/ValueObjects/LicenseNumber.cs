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
            this.Value = value;
        }
        private void ValidateLicenseNumber(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Licença inválida");
            }
        }

    }
}
