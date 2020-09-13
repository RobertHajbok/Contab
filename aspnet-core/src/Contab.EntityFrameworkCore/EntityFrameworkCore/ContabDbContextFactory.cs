using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Contab.Configuration;
using Contab.Web;

namespace Contab.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ContabDbContextFactory : IDesignTimeDbContextFactory<ContabDbContext>
    {
        public ContabDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ContabDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ContabDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ContabConsts.ConnectionStringName));

            return new ContabDbContext(builder.Options);
        }
    }
}
