using Cinema2.Data;
using Cinema2.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema2.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly ApplicationDbContext _context;

        // بنحقن الـ ApplicationDbContext هنا عشان نقدر نقرأ السينمات من الداتا بيز
        public CinemaService(ApplicationDbContext context)
        {
            _context = context;
        }

        // دالة بتجيب كل السينمات المسجلة في قاعدة البيانات
        public async Task<IEnumerable<Cinema>> GetAllCinemasAsync()
        {
            return await _context.Cinemas.ToListAsync();
        }
    }
}