using MediatR;
using OnionApp.Application.Features.Queries.CarPricingQueries;
using OnionApp.Application.Features.Results.CarPricingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResut>>
    {
        public Task<List<GetCarPricingWithTimePeriodQueryResut>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
