using MongoDB.Driver;
using System.Collections.Generic;

namespace Product.Infrastructure.Data
{
    internal class ProductContextSeed
    {
        public static void SeedData(IMongoDatabase database)
        {
            //InsertCategories(database.GetCollection<Category>(nameof(Category)));
            //InsertProducts(database.GetCollection<Product>(nameof(Product)));
        }
    }
}
