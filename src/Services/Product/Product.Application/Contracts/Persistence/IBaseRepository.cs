using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Application.Contracts.Persistence
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> RemoveAsync(Guid id);
    }
}
