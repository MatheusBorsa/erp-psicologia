using erp_psicologia_classes.Application.UseCases.Schedules.Dtos;
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
    public class CreateScheduleUseCase : IUseCase<CreateScheduleInputDto, CreateScheduleOutputDto>
    {
        private AppDbContext DbContext { get; set; }
        private VerifyAvaliableTimeUseCase VerifyAvaliableTimeUseCase { get; set; }
        public CreateScheduleUseCase(AppDbContext dbContext, VerifyAvaliableTimeUseCase verifyUseCase)
        {
            DbContext = dbContext;
            VerifyAvaliableTimeUseCase = verifyUseCase;
        }
        public CreateScheduleOutputDto Execute(CreateScheduleInputDto input)
        {
            VerifyAvaliableTimeInputDto verifyDto = new VerifyAvaliableTimeInputDto(
                input.Date,
                input.Start,
                input.End
            );
            bool avaliable = VerifyAvaliableTimeUseCase.Execute( verifyDto ).Avaliable;
            if (!avaliable)
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
            try
            {
                DbContext.SaveChanges();
                return new CreateScheduleOutputDto(true, schedule, "Cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return new CreateScheduleOutputDto(false,$"Houve um erro ao cadastrar um agendamento, {ex.Message}");
            }
        }
    }
}
