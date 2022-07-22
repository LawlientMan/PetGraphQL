using Product.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Application.Repositories
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<bool> RemoveAsync(string id);
    }
}
