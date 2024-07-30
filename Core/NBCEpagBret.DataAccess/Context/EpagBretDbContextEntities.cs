using Microsoft.EntityFrameworkCore;
using NBCEpagBret.Domain.Entities.Security;

namespace NBCEpagBret.DataAccess
{
    public partial class EpagBretDbContext
    {
        public DbSet<User> Users { get; init; } = default!;
    }
}