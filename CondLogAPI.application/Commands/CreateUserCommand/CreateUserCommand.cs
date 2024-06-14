using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Commands.CreateUserCommand
{
    public class CreateUserCommand:IRequest<Guid>
    {
        public string Name { get; set; }
        public string PhoneNumber { get;set; }
        public string Apartment { get;  set; }
        public string Block { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
