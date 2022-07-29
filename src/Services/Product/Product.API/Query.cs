using HotChocolate;
using Product.Application.Repositories;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.API
{
    public class Query
    {
        public Task<IEnumerable<Style>> GetProductsAsync([Service] IStyleRepository productRepository) =>
      productRepository.GetAllAsync();

        public Task<Style> GetProductById(string id, [Service] IStyleRepository productRepository) =>
            productRepository.GetByIdAsync(new Guid(id));
    }
}
