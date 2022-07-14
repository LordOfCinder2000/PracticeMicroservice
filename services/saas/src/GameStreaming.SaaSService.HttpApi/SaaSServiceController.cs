using GameStreaming.SaaSService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace GameStreaming.SaaSService;

public abstract class SaaSServiceController : AbpControllerBase
{
    protected SaaSServiceController()
    {
        LocalizationResource = typeof(SaaSServiceResource);
    }
}
