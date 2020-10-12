using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Data.Configurations
{
    public class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public override void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.HasBaseType<BaseCardEntity>();

        }
    }
}
