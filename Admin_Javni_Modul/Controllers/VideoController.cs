using Admin_Javni_Modul.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin_Javni_Modul.Controllers
{
    public class VideoController : Controller
    {
        private readonly AppDbContext _context;

        public VideoController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allVideos = await _context.Videos.ToListAsync();
            return View(allVideos);
        }
    }
}
