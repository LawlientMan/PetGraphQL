using HotChocolate;
using HotChocolate.Types;
using Product.API.Loaders;
using Product.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Product.API.Resolvers
{
    [ExtendObjectType("Skus")]
    public class SkuResolver
    {
        public async Task<IEnumerable<SKU>> GetSkusAsync([Parent] Option option, [Service] SkuBatchDataLoader skuDataLoader, CancellationToken cancellationToken) =>
            await skuDataLoader.LoadAsync(option.Id);
    }
}
