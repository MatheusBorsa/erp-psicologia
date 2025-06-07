using erp_psicologia_classes.Application.UseCases.Schedules.Dtos.SearchSchedules;
using erp_psicologia_classes.Domain.Entities;
using erp_psicologia_classes.Domain.Interfaces;
using erp_psicologia_classes.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erp_psicologia_classes.Application.UseCases.Schedules
{
    public class SearchSchedulesUseCase : BaseUseCase, IUseCase<SearchSchedulesInputDto, SearchSchedulesOutputDto>
    {
        public SearchSchedulesUseCase(AppDbContext context) : base(context)
        {

        }

        public SearchSchedulesOutputDto Execute(SearchSchedulesInputDto input)
        {
            IQueryable<Schedule> query = Context.Schedules.AsQueryable();
            if (input.Start.HasValue)
            {
                query = query.Where(x => x.Start == input.Start.Value);
            }

            if (input.End.HasValue)
            {
                query = query.Where(x => x.End == input.End.Value);
            }

            if (input.PatientId.HasValue)
            {
                query = query.Where(x => x.PatientId == input.PatientId.Value);
            }

            if (input.StartDate.HasValue)
            {
                query = query.Where(x => x.Date >= input.StartDate.Value.Date);
            }

            if (input.EndDate.HasValue)
            {
                query = query.Where(x => x.Date <= input.EndDate.Value.Date);
            }

            query = query.Where(x => x.DeletedAt == null);

            query.Include(x => x.Session);

            List<Schedule> results = query.ToList();

            return new SearchSchedulesOutputDto(results);

        }
    }
}
