using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Configurations
{
    public class CourseStudentConfiguration : BaseEntityConfiguration<CourseStudent>
    {
        public override void Configure(EntityTypeBuilder<CourseStudent> builder)
        {
            base.Configure(builder);
          
        }
    }
}
