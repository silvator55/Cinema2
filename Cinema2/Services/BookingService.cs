using Cinema2.Data;
using Cinema2.Models;

namespace Cinema2.Services
{
    public class BookingService : IBookingService
    {
        private readonly ApplicationDbContext _context;

        public BookingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task BookMovieAsync(int movieId, string userId)
        {
            var movie = await _context.Movies.FindAsync(movieId);
            if (movie == null)
            {
                throw new Exception("الفيلم غير موجود");
            }

            var booking = new Booking
            {
                MovieId = movieId,
                UserId = userId,
                TicketCount = 1,
                TotalPrice = movie.Price,
                BookingDate = DateTime.Now
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
        }
    }
}