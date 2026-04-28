using OnionApp.WebUI.Base;
using OnionApp.WebUI.Dtos.ReviewDtos;

namespace OnionApp.WebUI.Services.ReviewServices
{
    public interface IReviewService
    {
        Task<BaseResult<List<ResultReviewByCarIdDto>>> GetReviewsByCarId(int carId);
    }
}
