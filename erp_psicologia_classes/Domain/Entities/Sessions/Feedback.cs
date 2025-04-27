using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Domain.Entities.Sessions
{
    public class Feedback
    {
        // verificar se vale a pena usar uma entidade para isso. vou manter usando apenas como inteiro na sessão
        private int Value;
        public Feedback(int value)
        {
            this.Value = value;
        }


    }
}
