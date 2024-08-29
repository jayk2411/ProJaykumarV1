using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProJaykumarV1.Configuration;

namespace ProJaykumarV1.Web.Host.Startup
{
    [DependsOn(
       typeof(ProJaykumarV1WebCoreModule))]
    public class ProJaykumarV1WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProJaykumarV1WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProJaykumarV1WebHostModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            System.AppContext.SetSwitch("NpgSql.DisableDateTimeInfinityConversions", true);
            System.AppContext.SetSwitch("NpgSql.EnableLegecyTimestampBehavior", true);
        }
    }
}
