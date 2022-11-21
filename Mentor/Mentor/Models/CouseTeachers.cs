namespace Mentor.Models
{
    public class CouseTeachers
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TeachersId { get; set; }
        public Category Category { get; set; }
        public Teachers Teachers { get; set; }
    }
}
