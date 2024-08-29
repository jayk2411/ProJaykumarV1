using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ProJaykumarV1.Controllers
{
    public abstract class ProJaykumarV1ControllerBase: AbpController
    {
        protected ProJaykumarV1ControllerBase()
        {
            LocalizationSourceName = ProJaykumarV1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
