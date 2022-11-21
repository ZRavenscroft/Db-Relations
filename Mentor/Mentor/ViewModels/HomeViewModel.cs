using Mentor.Models;
using System.Collections.Generic;

namespace Mentor.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> Category { get; set; }
        public List<Courses> Courses { get; set; }
        public List<Teachers> Teachers { get; set; }
        public List<CouseTeachers> CouseTeachers { get; set; }
    }
}
