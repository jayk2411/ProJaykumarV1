using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProJaykumarV1.EntityFrameworkCore;
using ProJaykumarV1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ProJaykumarV1.Web.Tests
{
    [DependsOn(
        typeof(ProJaykumarV1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ProJaykumarV1WebTestModule : AbpModule
    {
        public ProJaykumarV1WebTestModule(ProJaykumarV1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProJaykumarV1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ProJaykumarV1WebMvcModule).Assembly);
        }
    }
}