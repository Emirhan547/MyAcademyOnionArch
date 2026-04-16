using Mapster;
using MediatR;
using OnionApp.Application.Base;
using OnionApp.Application.Contracts;
using OnionApp.Application.Features.Queries.CarPricingQueries;
using OnionApp.Application.Features.Results.CarPricingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler(ICarPricingRepository _repository) : IRequestHandler<GetCarPricingWithCarQuery, BaseResult<List<GetCarPricingWithCarQueryResult>>>
    {
        public async Task<BaseResult<List<GetCarPricingWithCarQueryResult>>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetCarPricingWithCar();
            return BaseResult<List<GetCarPricingWithCarQueryResult>>.Success(result.Adapt<List<GetCarPricingWithCarQueryResult>>());
        }
    }
}
