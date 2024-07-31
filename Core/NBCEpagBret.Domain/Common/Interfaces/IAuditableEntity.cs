using MongoDB.Bson;
using NBCEpagBret.Domain.Entities.Security;

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
        ObjectId? CreatedById { get; set; }

        /// <summary>
        /// Пользователь, создавший сущность.
        /// </summary>
        User? CreatedBy { get; set;}

        /// <summary>
        /// Дата и время создания сущности.
        /// </summary>
        DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Дата и время последнего изменения сущности.
        /// </summary>
        ObjectId? UpdatedById { get; set; }

        /// <summary>
        /// Пользователь, последним изменивший сущность.
        /// </summary>
        User? UpdatedBy { get; set;}

        /// <summary>
        /// Идентификатор пользователя, последним изменившем сущность.
        /// </summary>
        DateTime? UpdatedDateTime { get; set; }
    }
}