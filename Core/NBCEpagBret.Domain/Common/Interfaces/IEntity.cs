namespace NBCEpagBret.Domain.Common.Interfaces
{
    /// <summary>
    /// Базовый интерфейс для всех сущностей.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        public String Id { get; set; }
    }
}