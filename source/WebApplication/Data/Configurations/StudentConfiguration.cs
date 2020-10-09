using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Data.Configurations
{
    public class StudentConfiguration : BaseEntityConfiguration<Student>
    {
        public override void Configure(EntityTypeBuilder<Student> builder)
        {
            base.Configure(builder);
            builder.Metadata.FindNavigation(nameof(Student.LessonStudents)).SetPropertyAccessMode(PropertyAccessMode.Field);

        }
    }
}
