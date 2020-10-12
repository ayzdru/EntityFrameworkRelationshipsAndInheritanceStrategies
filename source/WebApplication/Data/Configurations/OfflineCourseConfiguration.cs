using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Data.Configurations
{
    public class OfflineCourseConfiguration : BaseEntityConfiguration<OfflineCourse>
    {
        public override void Configure(EntityTypeBuilder<OfflineCourse> builder)
        {
            base.Configure(builder);
            builder.HasOne(b => b.Course).WithMany(b => b.OfflineCourses).HasForeignKey(b => b.CourseId);
        }
    }
}
