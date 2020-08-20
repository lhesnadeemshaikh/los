using PHH.ReverseLOS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PHH.ReverseLOS
{
    [DependsOn(
        typeof(ReverseLOSEntityFrameworkCoreTestModule)
        )]
    public class ReverseLOSDomainTestModule : AbpModule
    {

    }
}