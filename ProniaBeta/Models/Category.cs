using System.ComponentModel.DataAnnotations;

namespace ProniaBeta.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name can not be empty!")]
        [MaxLength(25,ErrorMessage = "Maxmimum input range is 25 characters!")]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}