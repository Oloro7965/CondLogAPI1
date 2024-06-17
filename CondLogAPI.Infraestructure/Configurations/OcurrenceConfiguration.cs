using CondLogAPI.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondLogAPI.Infraestructure.Configurations
{
    public class OcurrenceConfiguration : IEntityTypeConfiguration<Ocurrence>
    {
        public void Configure(EntityTypeBuilder<Ocurrence> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
