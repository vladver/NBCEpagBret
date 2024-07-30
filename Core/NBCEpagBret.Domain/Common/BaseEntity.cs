using MongoDB.Bson;
using NBCEpagBret.Domain.Common.Interfaces;

namespace NBCEpagBret.Domain.Common
{
    /// <summary>
    /// Базовый класс сущностей.
    /// </summary>
    public abstract class BaseEntity : IEntity
    {
        /// <inheritdoc/>
        public ObjectId Id { get; set; } = default!;
    }
}