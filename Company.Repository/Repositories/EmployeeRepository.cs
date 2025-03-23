using Company.Data.contexts;
using Company.Data.Models;
using Company.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee> , IEmployeeRepository
    {
        private readonly CompanyDbcontext _context;

        public EmployeeRepository(CompanyDbcontext context) :base(context)
        {
        }
       
    }
}
