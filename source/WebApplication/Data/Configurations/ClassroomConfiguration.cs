using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Data.Configurations
{
    public class ClassroomConfiguration : BaseEntityConfiguration<Classroom>
    {
        public override void Configure(EntityTypeBuilder<Classroom> builder)
        {
            base.Configure(builder);
            builder.HasOne(b => b.Teacher).WithMany(b => b.Classrooms).HasForeignKey(b => b.TeacherId);
            builder.Metadata.FindNavigation(nameof(Classroom.ClassroomStudents)).SetPropertyAccessMode(PropertyAccessMode.Field);

        }
    }
}
