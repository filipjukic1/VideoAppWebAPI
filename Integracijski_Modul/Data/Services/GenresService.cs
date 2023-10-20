using Integracijski_Modul.Data.Models;
using Integracijski_Modul.Data.ViewModels;

namespace Integracijski_Modul.Data.Services
{
    public class GenresService
    {
        private AppDbContext _context;

        public GenresService(AppDbContext context)
        {
            _context = context;
        }


        public void AddGenres(GenreVM genre)
        {
            var _genres = new Genre()
            {
                Name = genre.Name,
                Description = genre.Description
             
            };
            _context.Genres.Add(_genres);
            _context.SaveChanges();
        }

        public List<Genre> GetAllGenres() => _context.Genres.ToList();
        public Genre GetGenreById(int genreId) => _context.Genres.FirstOrDefault(n => n.Id == genreId);

        public Genre UpdateGenreById(int genreId, GenreVM genre)
        {
            var _genre = _context.Genres.FirstOrDefault(n => n.Id == genreId);
            if (_genre != null)
            {
                _genre.Name = genre.Name;
                _genre.Description = genre.Description;
              
                _context.SaveChanges();
            }

            return _genre;
        }

        public void DeleteGenreById(int genreId)
        {
            var _genre = _context.Genres.FirstOrDefault(n => n.Id == genreId);
            if (_genre != null)
            {
                _context.Genres.Remove(_genre);
                _context.SaveChanges();
            }
        }


    }
}

