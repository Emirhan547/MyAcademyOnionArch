using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Application.Features.Queries.AppUserQueries;
using OnionApp.Application.Tools;

namespace OnionApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Index(GetCheckAppUserQuery query)
        {
            var values = await _mediator.Send(query);
            if(values.IsExist)
            {
                return Created("", JwtTokenGenerator.GenerateToken(values));
            }
            else
            {
                return BadRequest("Kullanıcı adı veya şifre hatalıdır");
            }
        }
    }
}
