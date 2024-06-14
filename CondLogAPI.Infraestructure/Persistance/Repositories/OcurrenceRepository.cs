using CondLogAPI.Core.Domain.Entities;
using CondLogAPI.Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.Infraestructure.Persistance.Repositories
{
    public class OcurrenceRepository : IOcurrenceRepository
    {
        private readonly CondLogDbContext _dbContext;

        public OcurrenceRepository(CondLogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Ocurrence ocurrence)
        {
            await _dbContext.Ocurrences.AddAsync(ocurrence);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Ocurrence>> GetAllAsync()
        {
            return await _dbContext.Ocurrences.ToListAsync();
        }

        public async Task<Ocurrence> GetByIdAsync(Guid id)
        {
            return await _dbContext.Ocurrences.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
