using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Data.Configurations
{
    public class OnlineCourseConfiguration : BaseEntityConfiguration<OnlineCourse>
    {
        public override void Configure(EntityTypeBuilder<OnlineCourse> builder)
        {
            base.Configure(builder);
            builder.HasOne(b => b.Course).WithMany(b => b.OnlineCourses).HasForeignKey(b => b.CourseId);
        }
    }
}
