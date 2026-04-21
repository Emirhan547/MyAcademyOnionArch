using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.CarDtos;

namespace OnionApp.WebUI.Services.CarServices
{
    public interface ICarService
    {
        Task<BaseResult<List<ResultCarWithBrandsDto>>> GetCarWithBrands();
        Task<BaseResult<List<ResultLast5CarsWithBrandsDto>>> GetLas5CarWithBrands();
        Task<BaseResult<List<ResultCarDto>>> GetAllAsync();
        Task<BaseResult<UpdateCarDto>> GetByIdAsync(int id);
        Task<BaseResult<object>> CreateAsync(CreateCarDto create);
        Task<BaseResult<object>> UpdateAsync(UpdateCarDto update);
        Task<BaseResult<object>> DeleteAsync(int id);
    }
}
