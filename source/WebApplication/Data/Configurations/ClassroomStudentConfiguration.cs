using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Configurations
{
    public class ClassroomStudentConfiguration : BaseEntityConfiguration<ClassroomStudent>
    {
        public override void Configure(EntityTypeBuilder<ClassroomStudent> builder)
        {
            base.Configure(builder);
            builder.Ignore(q => q.Id);
            builder.HasOne(b => b.Classroom).WithMany(b => b.ClassroomStudents).HasForeignKey(b => b.ClassroomId);
            builder.HasOne(b => b.Student).WithMany(b => b.ClassroomStudents).HasForeignKey(b => b.StudentId);
            builder.HasKey(q => new { q.ClassroomId, q.StudentId });
        }
    }
}
