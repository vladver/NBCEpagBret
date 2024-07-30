namespace NBCEpagBret.Domain.Common.Interfaces
{
    /// <summary>
    /// Интерфейс для сущностей с дополнительной информацией об авторах и о
    /// времени создания\изменения.
    /// </summary>
    public interface IAuditableEntity : IEntity
    {
        /// <summary>
        /// Идентификатор пользователя, создавшего сущность.
        /// </summary>
        String? CreatedBy { get; set; }

        /// <summary>
        /// Дата и время создания сущности.
        /// </summary>
        DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Дата и время последнего изменения сущности.
        /// </summary>
        String? UpdatedBy { get; set; }

        /// <summary>
        /// Идентификатор пользователя, последним изменившем сущность.
        /// </summary>
        DateTime? UpdatedDateTime { get; set; }
    }
}