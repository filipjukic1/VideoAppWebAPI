using Admin_Javni_Modul.Data;
using Admin_Javni_Modul.Data.Services;
using Admin_Javni_Modul.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Javni_Modul.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _service;

        public GenreController(IGenreService service)
        {
            _service=service;
        }
        public async Task<IActionResult> Index()
        {

            var allGenres= await _service.GetAll();
            return View(allGenres);
        }


        //Get request Genres/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description")]Genre genre)
        {
            if (ModelState.IsValid)
            {
                return View(genre);
            }
            _service.Add(genre);
            return RedirectToAction(nameof(Index));
        }
    }
}
