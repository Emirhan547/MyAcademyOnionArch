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
    public class GetCarCountByKmSmallerThen1000QueryHandler (IStatisticsRepository _repository): IRequestHandler<GetCarCountByKmSmallerThen1000Query, BaseResult<GetCarCountByKmSmallerThen1000QueryResult>>
    {
        public Task<BaseResult<GetCarCountByKmSmallerThen1000QueryResult>> Handle(GetCarCountByKmSmallerThen1000Query request, CancellationToken cancellationToken)
        {
            var result = _repository.GetCarCountByKmSmallerThen1000();
            return Task.FromResult(BaseResult<GetCarCountByKmSmallerThen1000QueryResult>.Success(result.Adapt<GetCarCountByKmSmallerThen1000QueryResult>()));
        }
    }
}
