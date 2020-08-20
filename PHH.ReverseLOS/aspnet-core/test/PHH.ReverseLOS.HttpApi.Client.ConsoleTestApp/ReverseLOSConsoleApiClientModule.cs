using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace PHH.ReverseLOS.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ReverseLOSHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ReverseLOSConsoleApiClientModule : AbpModule
    {
        
    }
}
