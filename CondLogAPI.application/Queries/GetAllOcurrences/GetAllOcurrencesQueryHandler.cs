using CondLogAPI.application.ViewModels;
using CondLogAPI.Core.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Queries.GetAllOcurrences
{
    public class GetAllOcurrencesQueryHandler : IRequestHandler<GetAllOcurrencesQuery, List<OcurrenceViewModel>>
    {
        private readonly IOcurrenceRepository _ocurrenceRepository;

        public GetAllOcurrencesQueryHandler(IOcurrenceRepository ocurrenceRepository)
        {
            _ocurrenceRepository = ocurrenceRepository;
        }

        public async Task<List<OcurrenceViewModel>> Handle(GetAllOcurrencesQuery request, CancellationToken cancellationToken)
        {
            var ocurrences = await _ocurrenceRepository.GetAllAsync();
            var ocurrencesViewModel = ocurrences.Select(b => new OcurrenceViewModel(b.Title,b.Apartment,b.Block,b.Subject,b.Created))
                 .ToList();
            return ocurrencesViewModel;
        }
    }
}
