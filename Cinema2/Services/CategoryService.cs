using Cinema2.Data;
using Cinema2.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema2.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        // بنحقن الـ ApplicationDbContext هنا عشان نقدر نقرأ التصنيفات من الداتا بيز
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        // دالة بتجيب كل التصنيفات المسجلة في قاعدة البيانات
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}