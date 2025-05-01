using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.ValueObjects
{
    public class Password
    {
        string Value { get; set; }
        public Password(string value)
        {
            ValidatePassword(value);
            Value = value;
        }
        private void ValidatePassword(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Senha inválida");
            }
            if(value.Length < 10)
            {
                throw new ArgumentException("A senha precisa ter mais de 10 caracteres");
            }

            if (!value.Any(char.IsUpper))
            {
                throw new ArgumentException("A senha precisa conter pelo menos uma letra maiúscula");
            }

            if (!value.Any(char.IsDigit))
            {
                throw new ArgumentException("A senha precisa conter pelo menos um número");
            }

            if (!value.Any(c => !char.IsLetterOrDigit(c)))
            {
                throw new ArgumentException("A senha precisa conter pelo menos um caractere especial");
            }
        }
    }
}
