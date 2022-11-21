using System.Collections.Generic;
using Yummy.Models;

namespace Yummy.ViewModels
{
    public class HomeViewModel
    {
        public List<Testimonial> Testimonials { get; set; }
        public List<Meals> Meals { get; set; }
        public List<Categories> Categories { get; set; }
    }
}
