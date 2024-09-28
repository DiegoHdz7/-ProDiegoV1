using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProDiegoV1.Configuration;
using Abp.AutoMapper;
using ProDiegoV1.Colleges.Dto;
using ProDiegoV1.models;
using ProDiegoV1.Students.Dto;

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

        public override void PreInitialize()
        {
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            System.AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            System.AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            // https://www.npgsql.org/efcore/release-notes/6.0.html?tabs=annotations


            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<College, CollegeDto>();
                config.CreateMap<CollegeDto, College>();

                config.CreateMap<College, CreateCollegeDto>();
                config.CreateMap<CreateCollegeDto, College>();

                config.CreateMap<College, UpdateCollegeDto>();
                config.CreateMap<UpdateCollegeDto, College>();

                config.CreateMap<College, CollegeDto>();
                config.CreateMap<CollegeDto, College>();

                config.CreateMap<Student, StudentDto>(); 
                config.CreateMap<StudentDto, Student>();
            });
        }


    }
}
