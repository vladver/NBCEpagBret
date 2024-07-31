using MongoDB.Bson;
using NBCEpagBret.Domain.Common.Interfaces;
using NBCEpagBret.Domain.Entities.Security;

namespace NBCEpagBret.Domain.Common
{
    /// <summary>
    /// Базовый класс для сущностей с дополнительной информацией об авторах и о
    /// времени создания\изменения.
    /// </summary>
    public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity
    {
        /// <inheritdoc/>
        public ObjectId? CreatedById { get; set; }

        /// <inheritdoc/>
        public User? CreatedBy { get; set;}

        /// <inheritdoc/>
        public DateTime? CreatedDateTime { get; set; }

        /// <inheritdoc/>
        public ObjectId? UpdatedById { get; set; }

        /// <inheritdoc/>
        public User? UpdatedBy { get; set;}        

        /// <inheritdoc/>
        public DateTime? UpdatedDateTime { get; set; }
    }
}