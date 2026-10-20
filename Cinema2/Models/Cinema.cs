namespace Cinema2.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? CinemaImg { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
