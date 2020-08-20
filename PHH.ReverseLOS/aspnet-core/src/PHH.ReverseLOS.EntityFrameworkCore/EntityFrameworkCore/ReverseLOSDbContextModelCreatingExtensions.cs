using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace PHH.ReverseLOS.EntityFrameworkCore
{
    public static class ReverseLOSDbContextModelCreatingExtensions
    {
        public static void ConfigureReverseLOS(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ReverseLOSConsts.DbTablePrefix + "YourEntities", ReverseLOSConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}