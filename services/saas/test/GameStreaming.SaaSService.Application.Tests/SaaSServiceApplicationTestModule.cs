using Volo.Abp.Modularity;

namespace GameStreaming.SaaSService;

[DependsOn(
    typeof(SaaSServiceApplicationModule),
    typeof(SaaSServiceDomainTestModule)
    )]
public class SaaSServiceApplicationTestModule : AbpModule
{

}
