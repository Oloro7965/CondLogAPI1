using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Commands.UpdateUserCommand
{
    public class UpdateUserCommand:IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string phoneNumber { get; set; }
        public string apartment { get; set; }
        public string block { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
