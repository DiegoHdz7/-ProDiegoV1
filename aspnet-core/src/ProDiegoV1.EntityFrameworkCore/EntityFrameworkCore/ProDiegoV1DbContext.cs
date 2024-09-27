using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProDiegoV1.Authorization.Roles;
using ProDiegoV1.Authorization.Users;
using ProDiegoV1.MultiTenancy;
using ProDiegoV1.models;

namespace ProDiegoV1.EntityFrameworkCore
{
    public class ProDiegoV1DbContext : AbpZeroDbContext<Tenant, Role, User, ProDiegoV1DbContext>
    {
        public virtual DbSet<Student> Students { get; set; }

        /* Define a DbSet for each entity of the application */

        public ProDiegoV1DbContext(DbContextOptions<ProDiegoV1DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Abp.Localization.ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }






    }
}
