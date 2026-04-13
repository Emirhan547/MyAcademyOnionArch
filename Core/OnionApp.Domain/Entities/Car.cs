using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImageUrl { get; set; }
        public virtual IList<CarFeature>CarFeatures { get; set; }
        public virtual IList<CarDescription>CarDescriptions { get; set; }
        public virtual IList<CarPricing> CarPricings { get; set; }
    }
}
 