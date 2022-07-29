using MongoDB.Driver;
using Product.Application.Contracts.Persistence;
using Product.Domain.Entities;
using Product.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Infrastructure.Repositories
{
    internal abstract class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected readonly IMongoCollection<T> collection;

        protected BaseRepository(IProductContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            this.collection = context.GetCollection<T>(typeof(T).Name);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await collection.Find(_ => true).ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq(_ => _.Id, id);

            return await collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            FilterDefinition<T> filter = Builders<T>.Filter.Eq(e => e.Id, entity.Id);
            await collection.ReplaceOneAsync(filter, entity);

            return entity;
        }

        public async Task<T> InsertAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await collection.InsertOneAsync(entity);

            return entity;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var result = await this.collection.DeleteOneAsync(Builders<T>.Filter.Eq(_ => _.Id, id));

            return result.DeletedCount > 0;
        }
    }
}
