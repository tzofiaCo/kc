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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseDetails>()
                .HasOne(c => c.Course)
                .WithMany(d=>d.CourseDetails).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
               .HasOne(c => c.Category)
               .WithMany(d => d.Courses).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Course>()
              .HasOne(c => c.Diploma)
              .WithMany(d => d.Courses).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Course>()
              .HasOne(c => c.Gender)
              .WithMany(d => d.Courses).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Course>()
              .HasOne(c => c.Owner)
              .WithMany(d => d.Courses).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Course>()
  .HasOne(c => c.Population)
  .WithMany(d => d.Courses).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Owner>()
  .HasOne(c => c.OwnerType)
  .WithMany(d => d.Owners).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Publication>()
.HasOne(c => c.CourseDetails)
.WithOne(d => d.Publication).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CourseDetails>()
.HasOne(p => p.Publication)
.WithOne(d => d.CourseDetails).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Publisher>()
  .HasOne(c => c.OwnerType)
  .WithMany(d => d.Publishers).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Publication>()
  .HasOne(c => c.Publisher)
  .WithMany(d => d.Publications).OnDelete(DeleteBehavior.Cascade);


        }



    }
}
