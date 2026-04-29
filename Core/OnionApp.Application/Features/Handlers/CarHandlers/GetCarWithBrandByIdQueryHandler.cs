using Mapster;
using MediatR;
using OnionApp.Application.Base;
using OnionApp.Application.Contracts;
using OnionApp.Application.Features.Queries.CarQueries;
using OnionApp.Application.Features.Results.CarResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Handlers.CarHandlers
{
    public class GetCarWithBrandByIdQueryHandler (ICarRepository _repository ): IRequestHandler<GetCarWithBrandByIdQuery, BaseResult<GetCarWithBrandByIdQueryResult>>
    {
        public async Task<BaseResult<GetCarWithBrandByIdQueryResult>> Handle(GetCarWithBrandByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetCarWithBrandByIdAsync(request.Id);
            if(result == null )
            {
                return BaseResult<GetCarWithBrandByIdQueryResult>.Fail("Bulunamadı");
            }
            return BaseResult<GetCarWithBrandByIdQueryResult>.Success(result.Adapt<GetCarWithBrandByIdQueryResult>());
        }
    }
}
