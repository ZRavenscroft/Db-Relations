using Microsoft.EntityFrameworkCore;
using Yummy.Models;

namespace Yummy.DAL
{
    public class YummyDbContext:DbContext
    {
        public YummyDbContext(DbContextOptions<YummyDbContext> options):base(options)
        {

        }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Meals> Meals { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
