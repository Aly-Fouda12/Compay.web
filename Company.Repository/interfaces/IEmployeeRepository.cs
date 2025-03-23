using Company.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.interfaces
{
    public interface IEmployeeRepository :IGenericRepository<Employee>
    {
    }
}
