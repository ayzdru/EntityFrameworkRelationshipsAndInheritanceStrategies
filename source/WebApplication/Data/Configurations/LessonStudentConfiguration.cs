using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Configurations
{
    public class LessonStudentConfiguration : BaseEntityConfiguration<LessonStudent>
    {
        public override void Configure(EntityTypeBuilder<LessonStudent> builder)
        {
            base.Configure(builder);
            builder.Ignore(q => q.Id);
            builder.HasOne(b => b.Lesson).WithMany(b => b.LessonStudents).HasForeignKey(b => b.LessonId);
            builder.HasOne(b => b.Student).WithMany(b => b.LessonStudents).HasForeignKey(b => b.StudentId);
            builder.HasKey(q => new { q.LessonId, q.StudentId });
        }
    }
}
