using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.EntityFrameworkCore.Extensions;
using NBCEpagBret.DataAccess.Common;
using NBCEpagBret.Domain.Entities.Security;

namespace NBCEpagBret.DataAccess.Configurations.Security
{
    internal class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.ToCollection("users");
        }
    }
}