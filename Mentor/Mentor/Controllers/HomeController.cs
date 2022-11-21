using Mentor.DAL;
using Mentor.Models;
using Mentor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Mentor.Controllers
{
    public class HomeController : Controller
    {
        private readonly MentorDbContext _context;
        public HomeController(MentorDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Category = _context.Categories.ToList(),
                Courses = _context.Courses.ToList(),
                CouseTeachers = _context.CouseTeachers.ToList(),
                Teachers = _context.Teachers.ToList()
            };
            return View(vm);
        }
    }
}
