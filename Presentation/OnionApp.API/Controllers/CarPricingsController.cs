using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Application.Features.Queries.CarPricingQueries;

namespace OnionApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController(IMediator _mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCarPricingWithCarList()
        {
            var values = await _mediator.Send(new GetCarPricingWithCarQuery());
            return values.IsSuccessful ? Ok(values) : BadRequest(values);
        }
    }
}
