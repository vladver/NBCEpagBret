using MongoDB.Driver;

namespace NBCEpagBret.DataAccess.Common.Interfaces
{
    public interface IEpagBretDbContext
    {
        IMongoCollection<T> GetCollection<T>(String name);
    }
}