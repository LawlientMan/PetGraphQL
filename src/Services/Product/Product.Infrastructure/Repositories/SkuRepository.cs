using Product.Application.Repositories;
using Product.Domain.Entities;
using Product.Infrastructure.Data;

namespace Product.Infrastructure.Repositories
{
    internal class SkuRepository : BaseRepository<SKU>, ISkuRepository
    {
        public SkuRepository(IProductContext context) : base(context)
        {
        }
    }
}
