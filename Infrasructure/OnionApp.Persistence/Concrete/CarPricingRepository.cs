using Microsoft.EntityFrameworkCore;
using OnionApp.Application.Contracts;
using OnionApp.Domain.Entities;
using OnionApp.Domain.Enums;
using OnionApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Persistence.Concrete
{
    public class CarPricingRepository(AppDbContext _context):ICarPricingRepository
    {
        public async Task<List<CarPricing>> GetCarPricingWithCar()
        {
            return await _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(z => z.Pricing).Where(z=>z.PricingId==2).ToListAsync();
        }

        public List<CarPricing> GetCarPricingWithTimePeriod()
        {
            var grouped = _context.CarPricings
                .Include(x => x.Car)
                .ThenInclude(x => x.Brand)
                .ToList()
                .GroupBy(x => x.CarId)
                .Select(g =>
                {
                    var first = g.First();

                    first.DailyAmount = g
                        .Where(x => x.Id == (int)PricingType.Daily)
                        .Select(x => x.Amount)
                        .FirstOrDefault();

                    first.WeeklyAmount = g
                        .Where(x => x.Id == (int)PricingType.Weekly)
                        .Select(x => x.Amount)
                        .FirstOrDefault();

                    first.MonthlyAmount = g
                        .Where(x => x.Id == (int)PricingType.Monthly)
                        .Select(x => x.Amount)
                        .FirstOrDefault();

                    return first;
                })
                .ToList();

            return grouped;
        }
    }
}
