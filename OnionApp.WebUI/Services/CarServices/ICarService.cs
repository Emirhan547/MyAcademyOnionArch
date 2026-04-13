using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.CarDtos;

namespace OnionApp.WebUI.Services.CarServices
{
    public interface ICarService
    {
        Task<BaseResult<List<ResultCarWithBrandsDto>>> GetCarWithBrands();
        Task<BaseResult<List<ResultLast5CarsWithBrandsDto>>> GetLas5CarWithBrands();
    }
}
