using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PHH.ReverseLOS.Data
{
    /* This is used if database provider does't define
     * IReverseLOSDbSchemaMigrator implementation.
     */
    public class NullReverseLOSDbSchemaMigrator : IReverseLOSDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}