using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Commands.UpdateOcurrenceCommand
{
    public class UpdateOcurrenceCommand:IRequest<Unit>
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
    }
}
