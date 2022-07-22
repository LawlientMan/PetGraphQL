using Product.Domain.Entities;
using System.Threading.Tasks;

namespace Product.Application.Repositories
{
    public interface IOptionRepository : IBaseRepository<Option>
    {
        Task<Option> InsertAsync(string styleId, Option Option);
    }
}
