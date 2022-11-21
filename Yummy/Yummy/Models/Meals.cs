using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yummy.Models
{
    public class Meals
    {
        public int Id { get; set; }
        public int CategoriesId { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        [MaxLength(50)]
        public string Img { get; set; }
        public Categories Categories { get; set; }
    }
}
