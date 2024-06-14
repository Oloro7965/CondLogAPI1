using CondLogAPI.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.Infraestructure.Persistance
{
    public class CondLogDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Ocurrence> Ocurrences { get; set; }
        public CondLogDbContext(DbContextOptions<CondLogDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
