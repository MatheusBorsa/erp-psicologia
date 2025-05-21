using erp_psicologia_classes.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases
{
    public abstract class BaseUseCase
    {
        protected AppDbContext Context { get; set; }

        protected BaseUseCase(AppDbContext context)
        {
            Context = context;
        }
    }
}
