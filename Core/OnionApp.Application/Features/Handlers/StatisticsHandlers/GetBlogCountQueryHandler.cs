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
    public class GetBlogCountQueryHandler(IStatisticsRepository _repository) : IRequestHandler<GetBlogCountQuery, BaseResult<GetBlogCountQueryResult>>
    {
        public Task<BaseResult<GetBlogCountQueryResult>> Handle(GetBlogCountQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetBlogCount();
            return Task.FromResult(BaseResult<GetBlogCountQueryResult>.Success(result.Adapt<GetBlogCountQueryResult>()));
        }
    }
}
