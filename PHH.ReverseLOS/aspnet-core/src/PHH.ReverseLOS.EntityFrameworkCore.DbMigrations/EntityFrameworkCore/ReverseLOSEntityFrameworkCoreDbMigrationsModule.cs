using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace PHH.ReverseLOS.EntityFrameworkCore
{
    [DependsOn(
        typeof(ReverseLOSEntityFrameworkCoreModule)
        )]
    public class ReverseLOSEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ReverseLOSMigrationsDbContext>();
        }
    }
}
