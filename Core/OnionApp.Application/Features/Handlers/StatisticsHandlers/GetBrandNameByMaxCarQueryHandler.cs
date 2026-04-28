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
    public class GetBrandNameByMaxCarQueryHandler(IStatisticsRepository _repository) : IRequestHandler<GetBrandNameByMaxCarQuery, BaseResult<GetBrandNameByMaxCarQueryResult>>
    {
        public Task<BaseResult<GetBrandNameByMaxCarQueryResult>> Handle(GetBrandNameByMaxCarQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetBrandNameByMaxCar();
            return Task.FromResult(BaseResult<GetBrandNameByMaxCarQueryResult>.Success(result.Adapt<GetBrandNameByMaxCarQueryResult>()));
        }
    }
}
