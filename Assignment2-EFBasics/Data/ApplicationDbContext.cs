using Microsoft.EntityFrameworkCore;
using Assignment2_EFBasics.Models;

namespace Assignment2_EFBasics.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Students = Set<Student>();
            Schedule = Set<Schedule>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Nhi", LastName = "Nguyen", Cohort = "2022"},
                new Student { Id = 2, FirstName = "Viet", LastName = "Nguyen", Cohort = "2019"},
                new Student { Id = 3, FirstName = "Phi", LastName = "Vo", Cohort = "2022"}
            );
            modelBuilder.Entity<Schedule>().HasData(
                new Schedule { Id = 1, MeetingDate = "MWF", Time = new TimeSpan(9, 0, 0), Subject = "Maths"},
                new Schedule { Id = 2, MeetingDate = "TT", Time = new TimeSpan(10, 30, 0), Subject = "Literature"},
                new Schedule { Id = 3, MeetingDate = "MWF", Time = new TimeSpan(9, 0, 0), Subject = "Networking"}
            );
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Schedule> Schedule { get; set; }

    }
}