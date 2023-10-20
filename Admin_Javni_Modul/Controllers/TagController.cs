using Admin_Javni_Modul.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin_Javni_Modul.Controllers
{
    public class TagController : Controller
    {
        private readonly AppDbContext _context;

        public TagController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allTags = await _context.Tags.ToListAsync();
            return View(allTags);
        }
    }
}
