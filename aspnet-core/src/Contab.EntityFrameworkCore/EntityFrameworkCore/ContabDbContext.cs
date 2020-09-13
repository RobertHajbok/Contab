using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Contab.Authorization.Roles;
using Contab.Authorization.Users;
using Contab.MultiTenancy;

namespace Contab.EntityFrameworkCore
{
    public class ContabDbContext : AbpZeroDbContext<Tenant, Role, User, ContabDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ContabDbContext(DbContextOptions<ContabDbContext> options)
            : base(options)
        {
        }
    }
}
