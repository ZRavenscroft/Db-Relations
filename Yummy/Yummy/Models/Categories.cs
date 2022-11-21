using System.ComponentModel.DataAnnotations;

namespace Yummy.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
