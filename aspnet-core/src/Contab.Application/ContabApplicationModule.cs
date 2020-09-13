using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Contab.Authorization;

namespace Contab
{
    [DependsOn(
        typeof(ContabCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ContabApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ContabAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ContabApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
