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
    public class CarDescriptionRepository (AppDbContext _context): ICarDescriptionRepository
    {
        public CarDescription GetCarDescription(int carId)
        {
            return _context.CarDescriptions.Where(x => x.CarId == carId).FirstOrDefault();
        }
    }
}
