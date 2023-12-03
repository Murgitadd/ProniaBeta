using ProniaBeta.Models;

namespace ProniaBeta.ViewModels
{
    public class HomeVM
    {
        public List<Product> Products { get; set; }
        public List<Slide> Slides { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Category> Categories { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
