using Admin_Javni_Modul.Models;

namespace Admin_Javni_Modul.Data.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetAll();

        Country GetById(int id);

        void Add(Country country);

        Country Update(int id, Country newCountry);

        void Delete(int id);

    }
}
