using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PHH.ReverseLOS.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ReverseLOSMigrationsDbContextFactory : IDesignTimeDbContextFactory<ReverseLOSMigrationsDbContext>
    {
        public ReverseLOSMigrationsDbContext CreateDbContext(string[] args)
        {
            ReverseLOSEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ReverseLOSMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ReverseLOSMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
