using Microsoft.EntityFrameworkCore;

namespace KocDL
{
    public class DKContext : DbContext
    {
        public DKContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<CourseDetails> CourseDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Population> Populations { get; set; }
        public DbSet<Diploma> Diplomas { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<OwnerType> OwnerTypes { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Gender> Genders { get; set; }





    }
}
