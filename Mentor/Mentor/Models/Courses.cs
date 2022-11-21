using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mentor.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Img { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public string Desc { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<CouseTeachers> CouseTeacher { get; set; }
    }
}
