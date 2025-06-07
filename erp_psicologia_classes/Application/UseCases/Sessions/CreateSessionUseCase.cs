using erp_psicologia_classes.Application.UseCases.Schedules;
using erp_psicologia_classes.Application.UseCases.Schedules.Dtos.CreateSchedule;
using erp_psicologia_classes.Application.UseCases.Sessions.Dto.CreateSession;
using erp_psicologia_classes.Domain.Entities;
using erp_psicologia_classes.Domain.Interfaces;
using erp_psicologia_classes.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Sessions
{
    public class CreateSessionUseCase : BaseUseCase, IUseCase<CreateSessionInputDto, CreateSessionOutputDto>
    {
        private CreateScheduleUseCase CreateScheduleUseCase { get; set; }
        public CreateSessionUseCase(AppDbContext context, CreateScheduleUseCase createScheduleUseCase) : base(context)
        {
            CreateScheduleUseCase = createScheduleUseCase;
        }

        public CreateSessionOutputDto Execute(CreateSessionInputDto input)
        {
            try
            {
                Context.Database.BeginTransaction();
                CreateScheduleOutputDto outputCreateScheduleDto = CreateScheduleUseCase.Execute(input.CreateScheduleInputDto);
                if (!outputCreateScheduleDto.Created)
                {
                    throw new Exception(outputCreateScheduleDto.Error);
                }

                Session session = new Session(
                    input.CreateScheduleInputDto.PsychologistId, 
                    input.CreateScheduleInputDto.PatientId,
                    outputCreateScheduleDto.Schedule.Id
                );

                Context.Add(session);
                Context.SaveChanges();
                Context.Database.CommitTransaction();
                return new CreateSessionOutputDto(true, session);
            }
            catch (Exception ex)
            {              
                Context.Database.RollbackTransaction();
                return new CreateSessionOutputDto(false, $"Houve um erro ao criar uma sessão {ex.Message}");
            }
        }
    }
}
