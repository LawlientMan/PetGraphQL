using MediatR;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Product.Application.Features.Skus.Queries
{
    public class GetSkusListByOptionId : IRequest<IEnumerable<SKU>>
    {
        public Guid OptionId { get; set; }

        public GetSkusListByOptionId(Guid optionId)
        {
            OptionId = optionId;
        }
    }
}
