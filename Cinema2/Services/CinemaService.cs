using Cinema2.Data;
using Cinema2.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema2.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly ApplicationDbContext _context;

        public CinemaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cinema>> GetAllCinemasAsync()
        {
            return await _context.Cinemas.ToListAsync();
        }
    }
}