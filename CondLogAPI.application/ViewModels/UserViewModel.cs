using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string name, string phoneNumber, string apartment, string block, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Apartment = apartment;
            Block = block;
            Email = email;
        }

        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Apartment { get; private set; }
        public string Block { get; private set; }
        public string Email { get; private set; }
    }
}
