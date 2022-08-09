using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Product.Infrastructure.Models.Configurations;

namespace Product.Infrastructure.Data
{
    public class ProductContext : IProductContext
    {
        private readonly IMongoDatabase _database;

        public ProductContext(IOptions<MongoDbOptions> mongoDbConfiguration)
        {
            var client = new MongoClient(mongoDbConfiguration.Value.ConnectionString);
            _database = client.GetDatabase(mongoDbConfiguration.Value.Database);
            ProductContextSeed.SeedData(_database);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}