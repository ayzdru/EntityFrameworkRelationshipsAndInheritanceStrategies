using Microsoft.AspNetCore.Identity;
using System;

namespace WebApplication.Interfaces
{
    public interface IBaseEntity
    {
        IdentityUser<Guid> CreatedByUser { get; }
        Guid? CreatedByUserId { get; }
        DateTime CreatedDate { get; }
        Guid Id { get; }
        IdentityUser<Guid> LastUpdatedByUser { get; }
        Guid? LastUpdatedByUserId { get; }
        byte[] RowVersion { get; }
        DateTime? UpdatedDate { get; }

        void SetCreateDateByUserId(Guid? createdByUserId);
        void SetUpdateDateByUserId(Guid? lastUpdatedByUserId);
    }
}