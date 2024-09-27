using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProDiegoV1.Configuration;
using ProDiegoV1.Web;

namespace ProDiegoV1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProDiegoV1DbContextFactory : IDesignTimeDbContextFactory<ProDiegoV1DbContext>
    {
        public ProDiegoV1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProDiegoV1DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProDiegoV1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProDiegoV1Consts.ConnectionStringName));

            return new ProDiegoV1DbContext(builder.Options);
        }
    }
}
