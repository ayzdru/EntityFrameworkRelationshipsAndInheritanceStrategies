using WebApplication.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Data.Configurations
{
    public class CardConfiguration : BaseEntityConfiguration<BaseCardEntity>
    {
        public override void Configure(EntityTypeBuilder<BaseCardEntity> builder)
        {
            base.Configure(builder);

        }
    }
}
