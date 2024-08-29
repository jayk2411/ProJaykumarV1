using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProJaykumarV1.Authorization;

namespace ProJaykumarV1
{
    [DependsOn(
        typeof(ProJaykumarV1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProJaykumarV1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProJaykumarV1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProJaykumarV1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
