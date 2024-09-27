using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProDiegoV1.Configuration;

namespace ProDiegoV1.Web.Host.Startup
{
    [DependsOn(
       typeof(ProDiegoV1WebCoreModule))]
    public class ProDiegoV1WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProDiegoV1WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProDiegoV1WebHostModule).GetAssembly());
        }
    }
}
