using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProJaykumarV1.Configuration;
using ProJaykumarV1.Web;

namespace ProJaykumarV1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProJaykumarV1DbContextFactory : IDesignTimeDbContextFactory<ProJaykumarV1DbContext>
    {
        public ProJaykumarV1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProJaykumarV1DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProJaykumarV1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProJaykumarV1Consts.ConnectionStringName));

            return new ProJaykumarV1DbContext(builder.Options);
        }
    }
}
