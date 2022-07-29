using MongoDB.Driver;
using Product.Infrastructure.Configurations;

namespace Product.Infrastructure.Data
{
    public class ProductContext : IProductContext
    {
        private readonly IMongoDatabase _database;

        public ProductContext(MongoDbConfiguration mongoDbConfiguration)
        {
            var client = new MongoClient(mongoDbConfiguration.ConnectionString);
            _database = client.GetDatabase(mongoDbConfiguration.Database);
            ProductContextSeed.SeedData(_database);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}