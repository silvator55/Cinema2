using Cinema2.Models;

namespace Cinema2.Services
{
    public interface ICinemaService
    {
        Task<IEnumerable<Cinema>> GetAllCinemasAsync();
    }
}