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
    public class GetCarCountByTranmissionIsAutoQueryHandler(IStatisticsRepository _repository) : IRequestHandler<GetCarCountByTranmissionIsAutoQuery, BaseResult<GetCarCountByTranmissionIsAutoQueryResult>>
    {
        public Task<BaseResult<GetCarCountByTranmissionIsAutoQueryResult>> Handle(GetCarCountByTranmissionIsAutoQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByTranmissionIsAuto();
            return Task.FromResult(BaseResult<GetCarCountByTranmissionIsAutoQueryResult>.Success(value.Adapt<GetCarCountByTranmissionIsAutoQueryResult>()));
        }
    }
}
