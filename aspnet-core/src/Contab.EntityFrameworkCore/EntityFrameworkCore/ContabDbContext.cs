using Abp.Zero.EntityFrameworkCore;
using Contab.Authorization.Roles;
using Contab.Authorization.Users;
using Contab.Cards;
using Contab.Currencies;
using Contab.Extensions;
using Contab.MultiTenancy;
using Contab.Operations;
using Microsoft.EntityFrameworkCore;

namespace Contab.EntityFrameworkCore
{
    public class ContabDbContext : AbpZeroDbContext<Tenant, Role, User, ContabDbContext>
    {
        public virtual DbSet<Operation> Operations { get; set; }

        public virtual DbSet<Card> Cards { get; set; }

        public virtual DbSet<CardType> CardTypes { get; set; }

        public virtual DbSet<Currency> Currencies { get; set; }

        public ContabDbContext(DbContextOptions<ContabDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedEnumValues<CardType, CardTypeEnum>(e => e);
            modelBuilder.SeedEnumValues<Currency, CurrencyEnum>(e => e);
        }
    }
}
