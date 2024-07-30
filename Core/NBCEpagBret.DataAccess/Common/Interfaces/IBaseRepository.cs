using MongoDB.Bson;

namespace NBCEpagBret.DataAccess.Common.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Create(TEntity obj);
        void Update(TEntity obj);
        void Delete(ObjectId id);
        Task<TEntity> Get(ObjectId id);
        Task<IEnumerable<TEntity>> Get();
    }
}