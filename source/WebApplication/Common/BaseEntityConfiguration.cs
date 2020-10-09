using WebApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Configurations
{
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.RowVersion).IsRowVersion();
            builder.HasOne(b => b.CreatedByUser).WithMany().HasForeignKey(b => b.CreatedByUserId);
            builder.HasOne(b => b.LastUpdatedByUser).WithMany().HasForeignKey(b => b.LastUpdatedByUserId);
        }
    }
}
