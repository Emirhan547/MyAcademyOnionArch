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
    public class GetCarBrandAndModelByRentPriceDailyMaxQueryHandler(IStatisticsRepository _repository) : IRequestHandler<GetCarBrandAndModelByRentPriceDailyMaxQuery, BaseResult<GetCarBrandAndModelByRentPriceDailyMaxQueryResult>>
    {
        public Task<BaseResult<GetCarBrandAndModelByRentPriceDailyMaxQueryResult>> Handle(GetCarBrandAndModelByRentPriceDailyMaxQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetCarBrandAndModelByRentPriceDailyMax();
            return Task.FromResult(BaseResult<GetCarBrandAndModelByRentPriceDailyMaxQueryResult>.Success(result.Adapt<GetCarBrandAndModelByRentPriceDailyMaxQueryResult>()));
        }
    }
}
