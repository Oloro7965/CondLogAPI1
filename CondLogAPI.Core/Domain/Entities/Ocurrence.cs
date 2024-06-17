using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.Core.Domain.Entities
{
    public class Ocurrence:BaseEntity
    {
        public Ocurrence(string title, string phoneNumber, string apartment, string block, string email, string subject)
        {
            Title = title;
            PhoneNumber = phoneNumber;
            Apartment = apartment;
            Block = block;
            Email = email;
            Subject = subject;
            Created=DateTime.Now;
        }

        public string Title { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Apartment { get; private set; }
        public string Block { get; private set; }
        public string Email { get; private set; }
        public string Subject { get;private  set; }
        public DateTime Created { get; private set; }
        public void Update(string phoneNumber,string email,string subject)
        {
            PhoneNumber = phoneNumber;
            Email = email;
            Subject = subject;
        }
    }
}
