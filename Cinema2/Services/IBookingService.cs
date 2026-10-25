namespace Cinema2.Services
{
    public interface IBookingService
    {
        Task BookMovieAsync(int movieId, string userId);
    }
}