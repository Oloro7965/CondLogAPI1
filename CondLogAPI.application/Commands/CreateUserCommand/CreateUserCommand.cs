using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.Commands.CreateUserCommand
{
    public class CreateUserCommand
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Apartment { get; private set; }
        public string Block { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
