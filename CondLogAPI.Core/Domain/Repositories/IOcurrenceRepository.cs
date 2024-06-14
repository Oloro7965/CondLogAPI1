using CondLogAPI.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.Core.Domain.Repositories
{
    public interface IOcurrenceRepository
    {
        Task<List<Ocurrence>> GetAllAsync();
        Task<Ocurrence> GetByIdAsync(Guid id);
        Task AddAsync(Ocurrence ocurrence);
        Task SaveChangesAsync();
    }
}
