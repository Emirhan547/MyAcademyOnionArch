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
    public class GetCarCountByFuelGasolineOrDieselQueryHandler (IStatisticsRepository _repository): IRequestHandler<GetCarCountByFuelGasolineOrDieselQuery, BaseResult<GetCarCountByFuelGasolineOrDieselQueryResult>>
    {
        public Task<BaseResult<GetCarCountByFuelGasolineOrDieselQueryResult>> Handle(GetCarCountByFuelGasolineOrDieselQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetCarCountByFuelGasolineOrDiesel();
            return Task.FromResult(BaseResult<GetCarCountByFuelGasolineOrDieselQueryResult>.Success(result.Adapt<GetCarCountByFuelGasolineOrDieselQueryResult>()));
        }
    }
}
