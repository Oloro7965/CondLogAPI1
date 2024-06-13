using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.Core.Domain.Entities
{
    public class User:BaseEntity
    {
        public User(string name, string phoneNumber, string apartment, string block, string email, string password)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Apartment = apartment;
            Block = block;
            Email = email;
            Password = password;
        }

        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Apartment { get; private set; }
        public string Block { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<Ocurrence> UserOcurrences { get;private set; }
        public bool IsDeleted { get; private set; }
    }
}
