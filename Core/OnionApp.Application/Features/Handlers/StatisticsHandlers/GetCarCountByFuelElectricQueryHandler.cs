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
    public class GetCarCountByFuelElectricQueryHandler(IStatisticsRepository _repository) : IRequestHandler<GetCarCountByFuelElectricQuery, BaseResult<GetCarCountByFuelElectricQueryResult>>
    {
        public Task<BaseResult<GetCarCountByFuelElectricQueryResult>> Handle(GetCarCountByFuelElectricQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetCarCountByFuelElectric();
            return Task.FromResult(BaseResult<GetCarCountByFuelElectricQueryResult>.Success(result.Adapt<GetCarCountByFuelElectricQueryResult>()));
        }
    }
}
