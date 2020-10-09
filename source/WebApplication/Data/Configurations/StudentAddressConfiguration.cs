using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Configurations
{
    public class StudentAddressConfiguration : BaseEntityConfiguration<StudentAddress>
    {
        public override void Configure(EntityTypeBuilder<StudentAddress> builder)
        {
            base.Configure(builder);
          
        }
    }
}
