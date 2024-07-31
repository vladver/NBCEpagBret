using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NBCEpagBret.Domain.Common;
using NBCEpagBret.Domain.Common.Interfaces;

namespace NBCEpagBret.DataAccess.Common
{
    internal abstract class BaseConfiguration<T>
        : IEntityTypeConfiguration<T>
        where T : BaseAuditableEntity, IAuditableEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasOne(e => e.CreatedBy)
                .WithMany()
                .HasForeignKey(e => e.CreatedById)
                .IsRequired(false);

            builder.HasOne(e => e.UpdatedBy)
                .WithMany()
                .HasForeignKey(e => e.UpdatedById)
                .IsRequired(false);
        }
    }
}