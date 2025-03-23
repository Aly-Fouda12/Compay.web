using Company.Data.Models;
using Company.Service.Interface;
using Company.Service.services;
using Microsoft.AspNetCore.Mvc;

namespace Company.web.Controllers
{
    public class DepartementController : Controller
    {
        private readonly IDepaertmentService _depaertmentService;
        public DepartementController(IDepaertmentService depaertmentService) {
            _depaertmentService = depaertmentService;
        }
        public IActionResult Index()
        {

            var departements = _depaertmentService.GetAll();
            return View(departements);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Departement departement)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _depaertmentService.Add(departement);

                    return RedirectToAction("Index");
                }

                ModelState.AddModelError("DepartmentError", "Inputs is not valid");

                return View(departement);
            }
            catch (Exception ex) {

                ModelState.AddModelError("DepartmentError", ex.Message);
                return View(departement);
            }
 
        }

        public IActionResult Details(int? id)
        {
            var departement = _depaertmentService.GetById(id);
           if (departement is null)
                return NotFound();
            return View(departement);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var departement = _depaertmentService.GetById(id);
            if (departement is null)
                return NotFound();
            return View(departement);
        }
        [HttpPost]

        public IActionResult Update(int? id, Departement departement)
        {
            //if (departement.Id != id.Value)
            //    return RedirectToAction("Home");

            _depaertmentService.Update(departement);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int? id, Departement departement)
        {
            _depaertmentService.Delete(departement);
            return RedirectToAction("Index");
        }

    }
}
