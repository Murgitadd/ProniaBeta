using ProniaBeta.Areas.Admin;
using ProniaBeta.DAL;
using ProniaBeta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaBeta.Areas.Admin.ViewModels.Blog;

namespace ProniaBeta.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Blog> blog = await _context.Blogs.ToListAsync();
            return View(blog);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
