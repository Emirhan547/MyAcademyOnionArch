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
    public class GetCarBrandAndModelByRentPriceDailyMinQueryHandler(IStatisticsRepository _repository) : IRequestHandler<GetCarBrandAndModelByRentPriceDailyMinQuery, BaseResult<GetCarBrandAndModelByRentPriceDailyMinQueryResult>>
    {
        public Task<BaseResult<GetCarBrandAndModelByRentPriceDailyMinQueryResult>> Handle(GetCarBrandAndModelByRentPriceDailyMinQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetCarBrandAndModelByRentPriceDailyMin();
            return Task.FromResult(BaseResult<GetCarBrandAndModelByRentPriceDailyMinQueryResult>.Success(result.Adapt<GetCarBrandAndModelByRentPriceDailyMinQueryResult>()));
        }
    }
}
