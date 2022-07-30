using MongoDB.Driver;
using Product.Application.Contracts.Persistence;
using Product.Domain.Entities;
using Product.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Infrastructure.Repositories
{
    internal class SkuRepository : BaseRepository<SKU>, ISkuRepository
    {
        public SkuRepository(IProductContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SKU>> GetAllByOptionIdAsync(Guid optionId)
        {
            FilterDefinition<SKU> filter = Builders<SKU>.Filter.Eq(_ => _.OptionId, optionId);

            return await collection.Find(filter).ToListAsync();
        }

        public async Task<IEnumerable<SKU>> GetBatchByOptionIdsAsync(IEnumerable<Guid> optionIds)
        {
            FilterDefinition<SKU> filter = Builders<SKU>.Filter.In(nameof(SKU.OptionId), optionIds);

            return await collection.Find(filter).ToListAsync();
        }
    }
}
