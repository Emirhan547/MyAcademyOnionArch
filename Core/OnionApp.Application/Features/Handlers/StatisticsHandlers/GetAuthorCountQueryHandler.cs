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
    public class GetAuthorCountQueryHandler (IStatisticsRepository _repository): IRequestHandler<GetAuthorCountQuery, BaseResult<GetAuthorCountQueryResult>>
    {
        public async Task<BaseResult<GetAuthorCountQueryResult>> Handle(GetAuthorCountQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetAuthorCount();
            return BaseResult<GetAuthorCountQueryResult>.Success(result.Adapt<GetAuthorCountQueryResult>());
        }
    }
}
