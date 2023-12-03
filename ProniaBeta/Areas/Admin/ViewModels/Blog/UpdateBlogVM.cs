using System.ComponentModel.DataAnnotations;

namespace ProniaBeta.Areas.Admin.ViewModels.Blog
{
    public class UpdateBlogVM
    {
        [Required(ErrorMessage = "Title can not be empty!")]
        [MaxLength(25, ErrorMessage = "Max input for title is 25 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description can not be empty!")]
        [MaxLength(100, ErrorMessage = "Max input for description is 100 characters.")]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Author name can not be empty!")]
        [MaxLength(25, ErrorMessage = "Max input for Author is 25 characters.")]
        public string Author { get; set; }
        public string Image { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
