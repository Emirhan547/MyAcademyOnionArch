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
    public class GetBrandCountQueryHandler (IStatisticsRepository _repository): IRequestHandler<GetBrandCountQuery, BaseResult<GetBrandCountQueryResult>>
    {
        public Task<BaseResult<GetBrandCountQueryResult>> Handle(GetBrandCountQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetBrandCount();
            return Task.FromResult(BaseResult<GetBrandCountQueryResult>.Success(result.Adapt<GetBrandCountQueryResult>()));
        }
    }
}
