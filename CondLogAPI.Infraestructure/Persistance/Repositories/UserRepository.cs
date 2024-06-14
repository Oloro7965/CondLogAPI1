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
    public class UserRepository : IUserRepository
    {
        private readonly CondLogDbContext _dbcontext;

        public UserRepository(CondLogDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddAsync(User user)
        {
            await _dbcontext.Users.AddAsync(user);

            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbcontext.Users.Where(u => u.IsDeleted.Equals(false)).ToListAsync();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _dbcontext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
