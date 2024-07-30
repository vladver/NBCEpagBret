using NBCEpagBret.Domain.Common.Interfaces;

namespace NBCEpagBret.Domain.Common
{
    /// <summary>
    /// Базовый класс сущностей.
    /// </summary>
    public abstract class BaseEntity : IEntity
    {
        /// <inheritdoc/>
        public String Id { get; set; } = default!;
    }
}