using MediatR;
using OnionApp.Application.Contracts;
using OnionApp.Application.Features.Queries.AppUserQueries;
using OnionApp.Application.Features.Results.AppUserResults;
using OnionApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Handlers.AppUserHandlers
{
    public class GetCheckAppUserQueryHandler(IAppUserRepository _repository) : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {
        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserQueryResult();

            var user = await _repository.GetByFilterUserAsync(
                x => x.Username == request.Username && x.Password == request.Password
            );

            if (user == null)
            {
                values.IsExist = false;
            }
            else
            {
                values.IsExist = true;
                values.UserName = user.Username;
                values.Id = user.Id;

                var role = await _repository.GetByFilterRoleAsync(x => x.AppRoleId == user.AppRoleId);
                values.Role = role.AppRoleName;
            }

            return values;
        }
    }
}
