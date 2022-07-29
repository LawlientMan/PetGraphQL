using HotChocolate;
using Product.Application.Repositories;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.API.Queries
{
    public class StyleQuery
    {
        private readonly IStyleRepository _styleRepository;
        public StyleQuery([Service] IStyleRepository styleRepository)
        {
            _styleRepository = styleRepository;
        }

        public Task<IEnumerable<Style>> GetProductsAsync() => _styleRepository.GetAllAsync();

        public Task<Style> GetProductById(string id) => _styleRepository.GetByIdAsync(new Guid(id));
    }
}
