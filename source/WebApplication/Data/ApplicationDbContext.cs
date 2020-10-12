using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApplication.Entities;
using WebApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<ClassroomStudent> ClassroomStudents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<BaseCardEntity> Cards { get; set; }
        private Guid? GetUserId(ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                return (Guid?)null;
            }
            return Guid.TryParse(principal.FindFirst(ClaimTypes.NameIdentifier)?.Value, out Guid userId) ? userId : (Guid?)null;
        }
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
              : base(options)
        {

            _httpContextAccessor = httpContextAccessor;
        }
        private void SetBaseEntity()
        {
            var userId = _httpContextAccessor != null ? GetUserId(_httpContextAccessor.HttpContext?.User) : null;
            foreach (var entry in ChangeTracker.Entries<IBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.SetCreateDateByUserId(userId);
                        break;
                    case EntityState.Modified:
                        entry.Entity.SetUpdateDateByUserId(userId);
                        break;
                }
            }
        }
        public override int SaveChanges()
        {
            SetBaseEntity();
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            SetBaseEntity();
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        }
    }
}
