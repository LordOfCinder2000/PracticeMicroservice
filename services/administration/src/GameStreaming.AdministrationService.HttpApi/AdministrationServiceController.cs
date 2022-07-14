using GameStreaming.AdministrationService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace GameStreaming.AdministrationService;

public abstract class AdministrationServiceController : AbpControllerBase
{
    protected AdministrationServiceController()
    {
        LocalizationResource = typeof(AdministrationServiceResource);
    }
}
