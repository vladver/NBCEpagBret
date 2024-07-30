using Microsoft.EntityFrameworkCore;

namespace NBCEpagBret.DataAccess
{
    public partial class EpagBretDbContext : DbContext
    {
        public EpagBretDbContext(DbContextOptions<EpagBretDbContext> options)
            : base(options)
        { }
    }
}