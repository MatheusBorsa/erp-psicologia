using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.ValueObjects
{
    public class Email
    {
        public string Value { get; set; }
        public Email(string value)
        {
            Value = value;
        }
        private void ValidateEmail(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value), "Email não pode ser nulo ou vazio.");
            }

            try
            {
                MailAddress addr = new MailAddress(value);
                if (addr.Address != value)
                {
                    throw new ArgumentException("Email inválido.");
                }
            }
            catch (FormatException)
            {
                throw new ArgumentException("Email em formato inválido.");
            }
        }
    }
}
