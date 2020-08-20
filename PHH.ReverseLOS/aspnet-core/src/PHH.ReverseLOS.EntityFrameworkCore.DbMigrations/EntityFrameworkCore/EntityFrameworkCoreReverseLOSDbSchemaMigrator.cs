using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PHH.ReverseLOS.Data;
using Volo.Abp.DependencyInjection;

namespace PHH.ReverseLOS.EntityFrameworkCore
{
    public class EntityFrameworkCoreReverseLOSDbSchemaMigrator
        : IReverseLOSDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreReverseLOSDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ReverseLOSMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ReverseLOSMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}