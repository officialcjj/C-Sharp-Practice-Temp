using System.Data.Entity;

namespace ObjectPractice
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDB-EF6CodeFirst")
        {
            Database.SetInitializer<SchoolContext>(new SchoolDBInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}