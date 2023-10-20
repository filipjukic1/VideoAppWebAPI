using Admin_Javni_Modul.Models;
using Microsoft.EntityFrameworkCore;

namespace Admin_Javni_Modul.Data.Services
{
    public class CountryService : ICountryService
    {
        private readonly AppDbContext _context;

        public CountryService(AppDbContext context)
        {
            _context=context;
        }
        public void Add(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Country>> GetAll()
        {
            var result = await _context.Countries.ToListAsync();
            return result;
        }

        public async Country GetById(int id)
        {
            var result=await _context.Countries.FirstOrDefaultAsync(n=>n.Id==id);
        }

        public Country Update(int id, Country newCountry)
        {
            throw new NotImplementedException();
        }
    }
}
