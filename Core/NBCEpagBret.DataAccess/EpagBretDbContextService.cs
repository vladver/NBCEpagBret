using MongoDB.Driver;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace NBCEpagBret.DataAccess
{
    public static class EpagBretDbContextService
    {
        public static IServiceCollection AddEpagBretDbContext(
            this IServiceCollection services,
            String connectionString,
            String databaseName)
        {
#if DEBUG
            services.AddDbContextFactory<EpagBretDbContext>(options =>
            {
                var mongoClient = new MongoClient(connectionString);
                options.UseMongoDB(mongoClient, databaseName)
                    .EnableSensitiveDataLogging();
            });
#else
            services.AddDbContextFactory<EpagBretDbContext>(options =>
            {
                var mongoClient = new MongoClient(connectionString);
                options.UseMongoDB(mongoClient, databaseName);
            });
#endif
            return services;
        }
    }
}