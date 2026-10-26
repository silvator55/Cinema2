using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema2.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; } 

        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;

        public int TicketCount { get; set; } = 1;
        public decimal TotalPrice { get; set; }
    }
}