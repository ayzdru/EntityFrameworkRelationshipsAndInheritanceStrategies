using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Data.Configurations
{
    public class TeacherConfiguration : BaseEntityConfiguration<Teacher>
    {
        public override void Configure(EntityTypeBuilder<Teacher> builder)
        {
            base.Configure(builder);
            builder.Metadata.FindNavigation(nameof(Teacher.Lessons)).SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
