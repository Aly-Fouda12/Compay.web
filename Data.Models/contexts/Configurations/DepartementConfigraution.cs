using Company.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.contexts.Configurations
{
    class DepartementConfigraution : IEntityTypeConfiguration<Departement>
    {
        public void Configure(EntityTypeBuilder<Departement> builder)
        {
            builder.Property(d => d.Id).UseIdentityColumn(10 , 10);

            builder.HasIndex(d => d.Code).IsUnique();

            builder.HasIndex(d => d.Name).IsUnique();
        }
    }
}
