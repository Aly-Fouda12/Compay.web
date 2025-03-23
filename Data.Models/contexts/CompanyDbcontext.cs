using Company.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.contexts
{
    public class CompanyDbcontext :DbContext
    {

        public CompanyDbcontext(DbContextOptions<CompanyDbcontext> options) : base(options)
        {

        }

        public CompanyDbcontext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departement> Departements { get; set; }

    }
}
