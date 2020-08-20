using PHH.ReverseLOS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PHH.ReverseLOS.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ReverseLOSEntityFrameworkCoreDbMigrationsModule),
        typeof(ReverseLOSApplicationContractsModule)
        )]
    public class ReverseLOSDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
