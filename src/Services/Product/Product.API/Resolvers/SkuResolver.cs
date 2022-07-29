using HotChocolate;
using HotChocolate.Types;
using Product.Application.Contracts.Persistence;
using Product.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.API.Resolvers
{
    [ExtendObjectType("Skus")]
    public class SkuResolver
    {
        public Task<IEnumerable<SKU>> GetSkusAsync([Parent] Option option, [Service] ISkuRepository skuRepository) =>
            skuRepository.GetAllByOptionIdAsync(option.Id);
    }
}
