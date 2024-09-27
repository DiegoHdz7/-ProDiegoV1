using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProDiegoV1.Authorization.Roles;
using ProDiegoV1.Authorization.Users;
using ProDiegoV1.MultiTenancy;

namespace ProDiegoV1.EntityFrameworkCore
{
    public class ProDiegoV1DbContext : AbpZeroDbContext<Tenant, Role, User, ProDiegoV1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProDiegoV1DbContext(DbContextOptions<ProDiegoV1DbContext> options)
            : base(options)
        {
        }
    }
}
