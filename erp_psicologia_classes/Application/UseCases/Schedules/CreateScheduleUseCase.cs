using erp_psicologia_classes.Application.UseCases.Schedules.Dtos.CreateSchedule;
using erp_psicologia_classes.Application.UseCases.Schedules.Dtos.VerifyAvaliableTime;
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
    public class CreateScheduleUseCase : BaseUseCase, IUseCase<CreateScheduleInputDto, CreateScheduleOutputDto>
    {
        private VerifyAvaliableTimeUseCase VerifyAvaliableTimeUseCase { get; set; }
        public CreateScheduleUseCase(AppDbContext context, VerifyAvaliableTimeUseCase verifyUseCase) : base(context)
        {
            VerifyAvaliableTimeUseCase = verifyUseCase;
        }

        public CreateScheduleOutputDto Execute(CreateScheduleInputDto input)
        {
            try
            {
                VerifyAvaliableTimeInputDto verifyDto = new VerifyAvaliableTimeInputDto(
                    input.Date,
                    input.Start,
                    input.End
                );
                if (VerifyAvaliableTimeUseCase.Execute(verifyDto).Avaliable)
                {
                    return new CreateScheduleOutputDto(false,"Paciente não encontrado");
                }

                Schedule schedule = new Schedule(
                    input.Date,
                    input.Start,
                    input.End,
                    input.PsychologistId,
                    input.PatientId
                );
                Context.Add(schedule);
                Context.SaveChanges();
                return new CreateScheduleOutputDto(true, schedule, "Cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return new CreateScheduleOutputDto(false,$"Houve um erro ao cadastrar um agendamento, {ex.Message}");
            }
        }
    }
}
