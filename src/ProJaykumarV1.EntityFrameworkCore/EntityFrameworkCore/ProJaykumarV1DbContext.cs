using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProJaykumarV1.Authorization.Roles;
using ProJaykumarV1.Authorization.Users;
using ProJaykumarV1.MultiTenancy;
using ProJaykumarV1.Models;

namespace ProJaykumarV1.EntityFrameworkCore
{
    public class ProJaykumarV1DbContext : AbpZeroDbContext<Tenant, Role, User, ProJaykumarV1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProJaykumarV1DbContext(DbContextOptions<ProJaykumarV1DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Abp.Localization.ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100);
        }

        public virtual DbSet<Student> Students { get; set; }
    }
}
