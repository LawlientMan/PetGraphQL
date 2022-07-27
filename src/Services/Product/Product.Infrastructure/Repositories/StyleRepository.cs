using Product.Application.Repositories;
using Product.Domain.Entities;
using Product.Infrastructure.Data;

namespace Product.Infrastructure.Repositories
{
    internal class StyleRepository : BaseRepository<Style>, IStyleRepository
    {
        public StyleRepository(IProductContext context) : base(context)
        {
        }
    }
}
