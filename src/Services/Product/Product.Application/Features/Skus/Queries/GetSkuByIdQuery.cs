using MediatR;
using Product.Domain.Entities;
using System;

namespace Product.Application.Features.Skus.Queries
{
    public class GetSkuByIdQuery : IRequest<SKU>
    {
        public Guid Id { get; set; }

        public GetSkuByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
