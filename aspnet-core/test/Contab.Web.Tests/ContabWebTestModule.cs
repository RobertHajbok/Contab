using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Contab.EntityFrameworkCore;
using Contab.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Contab.Web.Tests
{
    [DependsOn(
        typeof(ContabWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ContabWebTestModule : AbpModule
    {
        public ContabWebTestModule(ContabEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ContabWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ContabWebMvcModule).Assembly);
        }
    }
}