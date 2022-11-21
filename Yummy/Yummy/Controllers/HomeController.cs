using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Yummy.DAL;
using Yummy.Models;
using Yummy.ViewModels;

namespace Yummy.Controllers
{
    public class HomeController : Controller
    {
        private readonly YummyDbContext _context;
        public HomeController(YummyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Testimonials = _context.Testimonials.ToList(),
                Meals = _context.Meals.ToList(),
                Categories = _context.Categories.ToList(),
            };
            return View(vm);
        }
    }
}
