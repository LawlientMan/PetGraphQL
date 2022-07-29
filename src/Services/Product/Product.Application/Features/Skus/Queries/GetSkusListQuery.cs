using MediatR;
using Product.Domain.Entities;
using System.Collections.Generic;

namespace Product.Application.Features.Skus.Queries
{
    public class GetSkusListQuery : IRequest<IEnumerable<SKU>>
    {
    }
}
