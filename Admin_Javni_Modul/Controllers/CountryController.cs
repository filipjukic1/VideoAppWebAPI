using Admin_Javni_Modul.Data;
using Admin_Javni_Modul.Data.Services;
using Admin_Javni_Modul.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin_Javni_Modul.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryService _service;

        public CountryController(ICountryService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allCountries = await _service.GetAll();
            return View(allCountries);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Code,Name")] Country country)
        {
            if (ModelState.IsValid)
            {
                return View(country);
            }
            _service.Add(country);
            return RedirectToAction(nameof(Index));
        }

        //Get: COuntries/Details/{id}

        public async Task<IActionResult> Details(int id)
        {
            var countryDetails=_service.GetById(id);

            if (countryDetails == null) return View("Empty");
            {

            }
        }
    }
}
