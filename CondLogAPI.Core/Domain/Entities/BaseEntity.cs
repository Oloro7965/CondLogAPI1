using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.Core.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }
    }
}
