using WebApplication.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedDate { get; protected set; }
        public Guid? CreatedByUserId { get; protected set; }
        public IdentityUser<Guid> CreatedByUser { get; protected set; }
        public DateTime? UpdatedDate { get; protected set; }
        public Guid? LastUpdatedByUserId { get; protected set; }
        public IdentityUser<Guid> LastUpdatedByUser { get; protected set; }
        public byte[] RowVersion { get; protected set; }
        public void SetCreateDateByUserId(Guid? createdByUserId)
        {
            CreatedByUserId = createdByUserId;
            CreatedDate = DateTime.Now;
        }
        public void SetUpdateDateByUserId(Guid? lastUpdatedByUserId)
        {
            if (lastUpdatedByUserId.HasValue)
            {
                LastUpdatedByUserId = lastUpdatedByUserId;
                UpdatedDate = DateTime.Now;
            }
        }
    }
}
