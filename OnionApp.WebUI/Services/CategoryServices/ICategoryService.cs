using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.AboutDtos;
using OnionApp.WebUI.Dtos.CategoryDtos;

namespace OnionApp.WebUI.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<BaseResult<List<ResultCategoryDto>>> GetAllAsync();
        //Task<BaseResult<UpdateAboutDto>> GetByIdAsync(int id);
        //Task<BaseResult<object>> CreateAsync(CreateAboutDto create);
        //Task<BaseResult<object>> UpdateAsync(UpdateAboutDto update);
        //Task<BaseResult<object>> DeleteAsync(int id);
    }
}
