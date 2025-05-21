using erp_psicologia_classes.Application.UseCases.Session.Dto;
using erp_psicologia_classes.Domain.Interfaces;
using erp_psicologia_classes.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Session
{
    public class CreateSessionUseCase : BaseUseCase, IUseCase<CreateSessionInputDto, CreateSessionOutputDto>
    {
        public CreateSessionUseCase(AppDbContext context) : base(context)
        {
        }

        public CreateSessionOutputDto Execute(CreateSessionInputDto input)
        {
            throw new NotImplementedException();
        }
    }
}
