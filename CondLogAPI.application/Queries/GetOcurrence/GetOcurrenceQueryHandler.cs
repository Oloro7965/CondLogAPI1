using CondLogAPI.application.ViewModels;
using CondLogAPI.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Queries.GetOcurrence
{
    public class GetOcurrenceQueryHandler : IRequestHandler<GetOcurrenceQuery, OcurrenceViewModel>
    {
        private readonly IOcurrenceRepository _ocurrenceRepository;

        public GetOcurrenceQueryHandler(IOcurrenceRepository ocurrenceRepository)
        {
            _ocurrenceRepository = ocurrenceRepository;
        }

        public async Task<OcurrenceViewModel> Handle(GetOcurrenceQuery request, CancellationToken cancellationToken)
        {
            var ocurrence = await _ocurrenceRepository.GetByIdAsync(request.Id);

            var ocurrenceDetailViewModel = new OcurrenceViewModel(ocurrence.Title,ocurrence.Apartment,ocurrence.Block,ocurrence.Subject,ocurrence.Created);

            return ocurrenceDetailViewModel;
        }
    }
}
