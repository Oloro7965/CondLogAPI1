using CondLogAPI.Core.Domain.Entities;
using CondLogAPI.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Commands.CreateOcurrenceCommand
{
    public class CreateOcurrenceCommandHandler : IRequestHandler<CreateOcurrenceCommand, Guid>
    {
        private readonly IOcurrenceRepository _ocurrenceRepository;

        public CreateOcurrenceCommandHandler(IOcurrenceRepository ocurrenceRepository)
        {
            _ocurrenceRepository = ocurrenceRepository;
        }

        public async Task<Guid> Handle(CreateOcurrenceCommand request, CancellationToken cancellationToken)
        {
            var ocurrence = new Ocurrence(request.UserName,request.PhoneNumber,request.Apartment,request.Block,request.Email
                ,request.Subject);
            await _ocurrenceRepository.AddAsync(ocurrence);
            return ocurrence.Id;
        }
    }
}
