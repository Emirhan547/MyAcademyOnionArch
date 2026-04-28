using Mapster;
using MediatR;
using OnionApp.Application.Base;
using OnionApp.Application.Contracts;
using OnionApp.Application.Features.Queries.StatisticsQueries;
using OnionApp.Application.Features.Results.StatisticsResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Handlers.StatisticsHandlers
{
    public class GetAvgRentPriceForWeeklyQueryHandler(IStatisticsRepository _repository) : IRequestHandler<GetAvgRentPriceForWeeklyQuery, BaseResult<GetAvgRentPriceForWeeklyQueryResult>>
    {
        public Task<BaseResult<GetAvgRentPriceForWeeklyQueryResult>> Handle(GetAvgRentPriceForWeeklyQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAvgRentPriceForWeekly();
            return Task.FromResult(BaseResult<GetAvgRentPriceForWeeklyQueryResult>.Success(values.Adapt<GetAvgRentPriceForWeeklyQueryResult>()));
        }
    }
}
