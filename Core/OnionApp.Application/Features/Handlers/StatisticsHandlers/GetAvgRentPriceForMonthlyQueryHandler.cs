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
    public class GetAvgRentPriceForMonthlyQueryHandler(IStatisticsRepository _repository) : IRequestHandler<GetAvgRentPriceForMonthlyQuery, BaseResult<GetAvgRentPriceForMonthlyQueryResult>>
    {
        public Task<BaseResult<GetAvgRentPriceForMonthlyQueryResult>> Handle(GetAvgRentPriceForMonthlyQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetAvgRentPriceForMonthly();
            return Task.FromResult(BaseResult<GetAvgRentPriceForMonthlyQueryResult>.Success(result.Adapt<GetAvgRentPriceForMonthlyQueryResult>()));
        }
    }
}
