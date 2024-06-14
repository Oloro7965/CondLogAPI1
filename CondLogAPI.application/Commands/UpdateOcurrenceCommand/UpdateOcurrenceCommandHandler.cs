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

        public Task<Unit> Handle(UpdateOcurrenceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
