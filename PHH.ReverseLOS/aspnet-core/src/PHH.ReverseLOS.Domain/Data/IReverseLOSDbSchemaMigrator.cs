using System.Threading.Tasks;

namespace PHH.ReverseLOS.Data
{
    public interface IReverseLOSDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
