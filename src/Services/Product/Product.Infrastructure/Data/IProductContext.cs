using MongoDB.Driver;
namespace Product.Infrastructure.Data
{
    public interface IProductContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
