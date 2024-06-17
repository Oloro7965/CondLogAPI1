using CondLogAPI.application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Queries.GetOcurrence
{
    public class GetOcurrenceQuery:IRequest<OcurrenceViewModel>
    {
        public GetOcurrenceQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
