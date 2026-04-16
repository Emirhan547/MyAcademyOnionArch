using Microsoft.EntityFrameworkCore;
using OnionApp.Application.Contracts;
using OnionApp.Domain.Entities;
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
    }
}
