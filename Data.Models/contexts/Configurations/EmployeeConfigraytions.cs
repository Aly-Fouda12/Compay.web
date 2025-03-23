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
    class EmployeeConfigraytions : IEntityTypeConfiguration<Employee>
    {
        public void configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name).IsRequired(true).HasMaxLength(50);
        }

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            throw new NotImplementedException();
        }
    }
}
