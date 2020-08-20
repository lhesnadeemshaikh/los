using Volo.Abp.Modularity;

namespace PHH.ReverseLOS
{
    [DependsOn(
        typeof(ReverseLOSApplicationModule),
        typeof(ReverseLOSDomainTestModule)
        )]
    public class ReverseLOSApplicationTestModule : AbpModule
    {

    }
}