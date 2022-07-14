using GameStreaming.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace GameStreaming.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}
