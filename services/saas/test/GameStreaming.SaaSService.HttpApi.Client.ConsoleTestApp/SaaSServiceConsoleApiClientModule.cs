﻿using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace GameStreaming.SaaSService;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SaaSServiceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class SaaSServiceConsoleApiClientModule : AbpModule
{

}
