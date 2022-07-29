using MediatR;
using Product.Application.Contracts.Persistence;
using Product.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Application.Features.Skus.Queries
{
    public class SkuQuerisHandler : IRequestHandler<GetSkuByIdQuery, SKU>,
                                    IRequestHandler<GetSkusListByOptionId, IEnumerable<SKU>>,
                                    IRequestHandler<GetSkusListQuery, IEnumerable<SKU>>,
                                    IRequestHandler<GetSkuBatchByOptionIdsAsync, IEnumerable<SKU>>
    {
        private readonly ISkuRepository skuRepository;

        public SkuQuerisHandler(ISkuRepository skuRepository)
        {
            this.skuRepository = skuRepository;
        }

        public async Task<SKU> Handle(GetSkuByIdQuery request, CancellationToken cancellationToken)
        {
            SKU sku = await skuRepository.GetByIdAsync(request.Id);
            return sku;
        }

        public async Task<IEnumerable<SKU>> Handle(GetSkusListByOptionId request, CancellationToken cancellationToken)
        {
            IEnumerable<SKU> skus = await skuRepository.GetAllByOptionIdAsync(request.OptionId);
            return skus;
        }

        public async Task<IEnumerable<SKU>> Handle(GetSkusListQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<SKU> skus = await skuRepository.GetAllAsync();
            return skus;
        }

        public async Task<IEnumerable<SKU>> Handle(GetSkuBatchByOptionIdsAsync request, CancellationToken cancellationToken)
        {
            IEnumerable<SKU> skus = await skuRepository.GetBatchByOptionIdsAsync(request.OptionIds);
            return skus;
        }
    }
}
