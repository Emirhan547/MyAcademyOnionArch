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
    public class GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository _repository) : IRequestHandler<GetCarPricingWithTimePeriodQuery,List<GetCarPricingWithTimePeriodQueryResut>>
    {
        public async Task<List<GetCarPricingWithTimePeriodQueryResut>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingWithTimePeriod1();
            return values.Select(x => new GetCarPricingWithTimePeriodQueryResut
            {
                Brand = x.Brand,
                Model = x.Model,
                CoverImageUrl = x.CoverImageUrl,
                DailyAmount = x.Amounts[0],
                WeeklyAmount = x.Amounts[1],
                MonthlyAmount = x.Amounts[2]
            }).ToList();
        }

    }
}
