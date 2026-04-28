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
    public class GetAvgRentPriceForDailyQueryHandler(IStatisticsRepository _repository) : IRequestHandler<GetAvgRentPriceForDailyQuery, BaseResult<GetAvgRentPriceForDailyQueryResult>>
    {

        public Task<BaseResult<GetAvgRentPriceForDailyQueryResult>> Handle(GetAvgRentPriceForDailyQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetAvgRentPriceForDaily();

            return Task.FromResult(
                BaseResult<GetAvgRentPriceForDailyQueryResult>
                    .Success(result.Adapt<GetAvgRentPriceForDailyQueryResult>())
            );
        }
    }
}
