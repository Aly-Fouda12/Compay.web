using Company.Data.Models;
using Company.Repository.interfaces;
using Company.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.services
{
    public class DepartementService : IDepaertmentService
    {
        private readonly IDepartemnetRepository _departemnetRepository;

        public DepartementService(IDepartemnetRepository departemnetRepository) {

            _departemnetRepository = departemnetRepository;
        }
        public void Add(Departement departement)
        {
            
            var mapDepartement = new Departement
            {
                Name = departement.Name,
                Code = departement.Code,
                CreatedAt = DateTime.Now,

            };

            _departemnetRepository.Add(mapDepartement);

        }

        public void Delete(Departement departement)
        {
            _departemnetRepository.Delete(departement);
        }

        public IEnumerable<Departement> GetAll()
        {
           var departements = _departemnetRepository.GetAll();
            return departements;
        }

        public Departement GetById(int? id)
        {
            if(id is null)
                throw new Exception("Id is null");

            var departement = _departemnetRepository.GetById(id.Value);

            if(departement is null)
                throw new Exception("Departement not found");
            return departement;
        }

        public void Update(Departement departement)
        {
            _departemnetRepository.Update(departement);
        }
    }
}
