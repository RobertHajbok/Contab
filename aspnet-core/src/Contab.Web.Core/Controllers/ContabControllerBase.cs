using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Contab.Controllers
{
    public abstract class ContabControllerBase: AbpController
    {
        protected ContabControllerBase()
        {
            LocalizationSourceName = ContabConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
