using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Data.Configurations
{
    public class DebitCardConfiguration : IEntityTypeConfiguration<DebitCard>
    {
        public void Configure(EntityTypeBuilder<DebitCard> builder)
        {
            builder.HasBaseType<BaseCardEntity>();

        }
    }
}
