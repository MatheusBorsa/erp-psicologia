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
    public class SearchSchedulesUseCase : IUseCase<SearchSchedulesInputDto, SearchSchedulesOutputDto>
    {
        private AppDbContext DbContext { get; set; }
        public SearchSchedulesUseCase(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public SearchSchedulesOutputDto Execute(SearchSchedulesInputDto input)
        {
            IQueryable<Schedule> query = DbContext.Schedules.AsQueryable();
            if (input.Start.HasValue)
                query = query.Where(x => x.Start == input.Start.Value);

            if (input.End.HasValue)
                query = query.Where(x => x.End == input.End.Value);

            if (input.PatientId.HasValue)
                query = query.Where(x => x.PatientId == input.PatientId.Value);

            if (input.StartDate.HasValue)
                query = query.Where(x => x.Date >= input.StartDate.Value.Date);

            if (input.EndDate.HasValue)
                query = query.Where(x => x.Date <= input.EndDate.Value.Date);

            List<Schedule> results = query.ToList();

            return new SearchSchedulesOutputDto(results);

        }
    }
}
