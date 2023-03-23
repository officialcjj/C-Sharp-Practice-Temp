using System.Data.Entity.ModelConfiguration;

namespace ObjectPractice
{
    public class StudentConfigurations : EntityTypeConfiguration<Student>
    {
        public StudentConfigurations()
        {
            this.Property(s => s.StudentName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.StudentName)
                .IsConcurrencyToken();
        }
    }
}