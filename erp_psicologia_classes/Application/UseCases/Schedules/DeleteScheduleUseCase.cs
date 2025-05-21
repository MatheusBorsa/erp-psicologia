using erp_psicologia_classes.Application.UseCases.Schedules.Dtos.DeleteSchedule;
using erp_psicologia_classes.Domain.Entities;
using erp_psicologia_classes.Domain.Interfaces;
using erp_psicologia_classes.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules
{
    public class DeleteScheduleUseCase : BaseUseCase, IUseCase<DeleteScheduleInputDto, DeleteScheduleOutputDto>
    {
        public DeleteScheduleUseCase(AppDbContext context) : base(context)
        {
        }

        public DeleteScheduleOutputDto Execute(DeleteScheduleInputDto input)
        {
            Schedule? schedule = Context.Schedules.Find(input.ScheduleId);
            if (schedule == null)
            {
                return new DeleteScheduleOutputDto("Agendamento não encontrado", true);
            }
            schedule.DeletedAt = DateTime.Now;
            Context.SaveChanges();
            return new DeleteScheduleOutputDto($"Agendamento deletado com sucesso {schedule.Id}");
        }
    }
}
