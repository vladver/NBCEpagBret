using Microsoft.EntityFrameworkCore;
using NBCEpagBret.DataAccess.Configurations.Security;

namespace NBCEpagBret.DataAccess
{
    public partial class EpagBretDbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}