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
    public class GetBlogTitleByMaxBlogCommentQueryHandler (IStatisticsRepository _repository): IRequestHandler<GetBlogTitleByMaxBlogCommentQuery, BaseResult<GetBlogTitleByMaxBlogCommentQueryResult>>
    {
        public Task<BaseResult<GetBlogTitleByMaxBlogCommentQueryResult>> Handle(GetBlogTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetBlogTitleByMaxBlogComment();
            return Task.FromResult(BaseResult<GetBlogTitleByMaxBlogCommentQueryResult>.Success(result.Adapt<GetBlogTitleByMaxBlogCommentQueryResult>()));
        }
    }
}
