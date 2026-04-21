using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Application.Features.Queries.StatisticsQueries;

namespace OnionApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController(IMediator _mediator) : ControllerBase
    {
        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var result = await _mediator.Send(new GetCarCountQuery());
            return result.IsSuccessful ? Ok(result) : BadRequest(result );
        }
        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var result=await _mediator.Send(new GetAuthorCountQuery());
            return result.IsSuccessful ? Ok(result) : BadRequest(result);
        }
        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var result = await _mediator.Send(new GetLocationCountQuery());
            return result.IsSuccessful ? Ok(result) : BadRequest(result);
        }
    }
}
