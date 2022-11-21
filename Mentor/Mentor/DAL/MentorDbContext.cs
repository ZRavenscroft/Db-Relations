using Mentor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Mentor.DAL
{
    public class MentorDbContext:DbContext
    {
        public MentorDbContext(DbContextOptions<MentorDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CouseTeachers> CouseTeachers { get; set; }
    }
}
