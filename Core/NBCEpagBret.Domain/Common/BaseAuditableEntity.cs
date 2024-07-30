using MongoDB.Bson;
using NBCEpagBret.Domain.Common.Interfaces;

namespace NBCEpagBret.Domain.Common
{
    /// <summary>
    /// Базовый класс для сущностей с дополнительной информацией об авторах и о
    /// времени создания\изменения.
    /// </summary>
    public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity
    {
        /// <inheritdoc/>
        public ObjectId? CreatedBy { get; set; }

        /// <inheritdoc/>
        public DateTime? CreatedDateTime { get; set; }

        /// <inheritdoc/>
        public ObjectId? UpdatedBy { get; set; }

        /// <inheritdoc/>
        public DateTime? UpdatedDateTime { get; set; }
    }
}