using GreenDonut;
using MediatR;
using Product.Application.Features.Skus.Queries;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Product.API.Loaders
{
    public class SkuBatchDataLoader : BatchDataLoader<Guid, IEnumerable<SKU>>
    {
        private readonly IMediator mediator;

        public SkuBatchDataLoader(IMediator mediator, IBatchScheduler batchScheduler, DataLoaderOptions options = null)
            : base(batchScheduler, options)
        {
            this.mediator = mediator;
        }

        protected override async Task<IReadOnlyDictionary<Guid, IEnumerable<SKU>>> LoadBatchAsync(IReadOnlyList<Guid> keys, CancellationToken cancellationToken)
        {
            IEnumerable<SKU> skus = await mediator.Send(new GetSkuBatchByOptionIdsAsync(keys));

            return skus.GroupBy(x => x.OptionId).ToDictionary(i => i.Key, i => (IEnumerable<SKU>)i.ToList());
        }
    }
}
