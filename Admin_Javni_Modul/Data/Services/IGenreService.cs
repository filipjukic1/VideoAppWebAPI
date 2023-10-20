using Admin_Javni_Modul.Models;

namespace Admin_Javni_Modul.Data.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAll();

        Genre GetById(int id);

        void Add(Genre genre);

        Genre Update(int id, Genre newGenre);

        void Delete(int id);

    }
}
