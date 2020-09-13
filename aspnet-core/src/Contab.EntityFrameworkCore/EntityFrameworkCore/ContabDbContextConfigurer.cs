using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Contab.EntityFrameworkCore
{
    public static class ContabDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ContabDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ContabDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
