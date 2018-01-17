using System.Data.Entity;

namespace WpfApp.Model
{
    public class DataContextModel : DbContext
    {
        public DbSet<CadCli.Infra.Mapping.ClientTypeMap> ClientType { get; set; }
    }
}
