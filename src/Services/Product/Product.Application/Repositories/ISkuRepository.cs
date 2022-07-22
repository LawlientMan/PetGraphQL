using Product.Domain.Entities;
using System.Threading.Tasks;

namespace Product.Application.Repositories
{
    public interface ISkuRepository : IBaseRepository<SKU>
    {
        Task<SKU> InsertAsync(string optionId, SKU sku);
    }
}
