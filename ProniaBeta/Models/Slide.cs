using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProniaBeta.Models
{
    public class Slide
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name can not be empty!")]
        [MaxLength(25, ErrorMessage = "Maxmimum input range is 25 characters!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Name can not be empty!")]
        [MaxLength(50, ErrorMessage = "Maxmimum input range is 50 characters!")]
        public string SubTitle { get; set; }
        [Required(ErrorMessage = "Name can not be empty!")]
        [MaxLength(100, ErrorMessage = "Maxmimum input range is 100 characters!")]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}