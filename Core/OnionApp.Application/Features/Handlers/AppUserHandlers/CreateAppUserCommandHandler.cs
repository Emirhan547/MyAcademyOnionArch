using MediatR;
using OnionApp.Application.Contracts;
using OnionApp.Application.Features.Commands.AppUserCommands;
using OnionApp.Domain.Entities;
using OnionApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Handlers.AppUserHandlers
{
    public class CreateAppUserCommandHandler (IRepository<AppUser> _repository): IRequestHandler<CreateAppUserCommand>
    {
        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser
            {
                Password = request.Password,
                Username = request.Username,
                Name= request.Name,
                Surname = request.Surname,
                Email = request.Email,
                AppRoleId = (int)RolesType.Member
            });
        }
    }
}
