using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Data.Configurations
{
    public class LessonConfiguration : BaseEntityConfiguration<Course>
    {
        public override void Configure(EntityTypeBuilder<Course> builder)
        {
            base.Configure(builder);
            builder.HasOne(b => b.Teacher).WithMany(b => b.Courses).HasForeignKey(b => b.TeacherId);
            builder.Metadata.FindNavigation(nameof(Course.CourseStudents)).SetPropertyAccessMode(PropertyAccessMode.Field);

        }
    }
}
