using System.ComponentModel.DataAnnotations;

namespace Cinema2.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "يرجى إدخال اسم الممثل")]
        [Display(Name = "اسم الممثل")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "صورة الممثل")]
        public string? ProfileImg { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
    }
}