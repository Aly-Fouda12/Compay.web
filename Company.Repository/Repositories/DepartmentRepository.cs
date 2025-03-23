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
    public class DepartmentRepository :GenericRepository<Departement> ,IDepartemnetRepository
    {

        private readonly CompanyDbcontext _context;

        public DepartmentRepository(CompanyDbcontext context):base(context)
        {
        }
    }
}
