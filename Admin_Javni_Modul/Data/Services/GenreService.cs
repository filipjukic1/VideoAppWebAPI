using Admin_Javni_Modul.Models;
using Microsoft.EntityFrameworkCore;

namespace Admin_Javni_Modul.Data.Services
{
    public class GenreService : IGenreService
    {
        private readonly AppDbContext _context;
        public GenreService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            var result = await _context.Genres.ToListAsync();
            return result;
        }

        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Genre Update(int id, Genre newGenre)
        {
            throw new NotImplementedException();
        }
    }
}
