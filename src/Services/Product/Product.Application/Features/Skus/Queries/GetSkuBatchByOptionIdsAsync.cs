using MediatR;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Product.Application.Features.Skus.Queries
{
    public class GetSkuBatchByOptionIdsAsync : IRequest<IEnumerable<SKU>>
    {
        public IEnumerable<Guid> OptionIds { get; set; }

        public GetSkuBatchByOptionIdsAsync(IEnumerable<Guid> optionIds)
        {
            OptionIds = optionIds;
        }
    }
}
