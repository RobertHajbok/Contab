using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Contab.Authorization.Roles;
using Contab.Authorization.Users;
using Contab.MultiTenancy;
using Contab.Cards;
using Contab.Extensions;

namespace Contab.EntityFrameworkCore
{
    public class ContabDbContext : AbpZeroDbContext<Tenant, Role, User, ContabDbContext>
    {
        public virtual DbSet<CardType> CardTypes { get; set; }

        public ContabDbContext(DbContextOptions<ContabDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedEnumValues<CardType, CardTypeEnum>(e => e);
        }
    }
}
