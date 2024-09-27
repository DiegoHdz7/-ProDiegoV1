using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProDiegoV1.EntityFrameworkCore;
using ProDiegoV1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ProDiegoV1.Web.Tests
{
    [DependsOn(
        typeof(ProDiegoV1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ProDiegoV1WebTestModule : AbpModule
    {
        public ProDiegoV1WebTestModule(ProDiegoV1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProDiegoV1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ProDiegoV1WebMvcModule).Assembly);
        }
    }
}