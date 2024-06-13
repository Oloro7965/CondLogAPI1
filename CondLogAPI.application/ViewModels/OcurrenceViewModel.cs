using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.application.ViewModels
{
    public class OcurrenceViewModel
    {
        public string UserName { get; private set; }
        public string Apartment { get; private set; }
        public string Block { get; private set; }
        public string Subject { get; private set; }
        public DateTime Created { get; private set; }
    }
}
