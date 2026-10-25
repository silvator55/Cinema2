using Cinema2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cinema2.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IBookingService _bookingService;

        // حقن التبعيات (Dependency Injection) لكل الخدمات المخصصة
        public HomeController(IMovieService movieService, IBookingService bookingService)
        {
            _movieService = movieService;
            _bookingService = bookingService;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetAllMoviesAsync();
            return View(movies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movie = await _movieService.GetMovieByIdAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost]
        public async Task<IActionResult> BookMovie(int movieId)
        {
            try
            {
                await _bookingService.BookMovieAsync(movieId, "Guest-User");
                TempData["Success"] = "تم الحجز بنجاح!";
            }
            catch
            {
                TempData["Error"] = "حدث خطأ أثناء الحجز.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}