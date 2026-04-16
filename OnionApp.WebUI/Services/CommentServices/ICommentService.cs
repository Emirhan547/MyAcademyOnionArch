using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.CommentDtos;

namespace OnionApp.WebUI.Services.CommentServices
{
    public interface ICommentService
    {
        Task<BaseResult<List<ResultCommentDto>>> GetAllAsync();
        Task<BaseResult<UpdateCommentDto>> GetByIdAsync(int id);
        Task<BaseResult<object>> CreateAsync(CreateCommentDto create);
        Task<BaseResult<object>> UpdateAsync(UpdateCommentDto update);
        Task<BaseResult<object>> DeleteAsync(int id);
    }
}
