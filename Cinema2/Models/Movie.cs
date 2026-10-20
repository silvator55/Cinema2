using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Cinema2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "يرجى إدخال اسم الفيلم")]
        [Display(Name = "اسم الفيلم")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "يرجى إدخال وصف الفيلم")]
        [Display(Name = "الوصف")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "يرجى إدخال سعر التذكرة")]
        [Range(1, 10000, ErrorMessage = "السعر يجب أن يكون بين 1 و 10000")]
        [Display(Name = "سعر التذكرة")]
        public decimal Price { get; set; }

        [Display(Name = "حالة العرض")]
        public string Status { get; set; } = "Available";

        [Required(ErrorMessage = "يرجى تحديد موعد العرض")]
        [Display(Name = "موعد العرض")]
        public DateTime DateTime { get; set; }

        [Display(Name = "الصورة الرئيسية")]
        public string? MainImg { get; set; }

        [Required(ErrorMessage = "يرجى اختيار التصنيف")]
        [Display(Name = "التصنيف")]
        public int CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "يرجى اختيار السينما")]
        [Display(Name = "السينما")]
        public int CinemaId { get; set; }

        [ValidateNever]
        public Cinema Cinema { get; set; } = null!;

        [ValidateNever]
        public ICollection<MovieImage> SubImages { get; set; } = new List<MovieImage>();

        [ValidateNever]
        public ICollection<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
    }
}