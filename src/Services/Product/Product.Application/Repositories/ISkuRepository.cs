using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Application.Repositories
{
    public interface ISkuRepository : IBaseRepository<SKU>
    {
        Task<IEnumerable<SKU>> GetAllByOptionIdAsync(Guid optionId);
    }
}
