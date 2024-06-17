using CondLogAPI.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Commands.UpdateOcurrenceCommand
{
    public class UpdateOcurrenceCommandHandler : IRequestHandler<UpdateOcurrenceCommand, Unit>
    {
        private readonly IOcurrenceRepository _ocurrenceRepository;

        public UpdateOcurrenceCommandHandler(IOcurrenceRepository ocurrenceRepository)
        {
            _ocurrenceRepository = ocurrenceRepository;
        }

        public async Task<Unit> Handle(UpdateOcurrenceCommand request, CancellationToken cancellationToken)
        {
            var ocurrence = await _ocurrenceRepository.GetByIdAsync(request.Id);

            ocurrence.Update(request.Title,request.PhoneNumber, request.Email,request.Subject);

            _ocurrenceRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
