using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProDiegoV1.Authorization;

namespace ProDiegoV1
{
    [DependsOn(
        typeof(ProDiegoV1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProDiegoV1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProDiegoV1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProDiegoV1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
