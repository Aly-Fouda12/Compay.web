using Company.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Interface
{
    public interface IDepaertmentService
    {

        Departement GetById(int? id);
        IEnumerable<Departement> GetAll();
        void Add(Departement departement);
        void Update(Departement departement);
        void Delete(Departement departement);


    }
}
