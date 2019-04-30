using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using supplyc.Authorization.Roles;
using supplyc.Authorization.Users;
using supplyc.MultiTenancy;

namespace supplyc.EntityFrameworkCore
{
    public class supplycDbContext : AbpZeroDbContext<Tenant, Role, User, supplycDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public supplycDbContext(DbContextOptions<supplycDbContext> options)
            : base(options)
        {
        }
    }
}
