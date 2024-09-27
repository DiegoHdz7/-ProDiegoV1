using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ProDiegoV1.Controllers
{
    public abstract class ProDiegoV1ControllerBase: AbpController
    {
        protected ProDiegoV1ControllerBase()
        {
            LocalizationSourceName = ProDiegoV1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
