using HotChocolate;
using HotChocolate.Types;
using MediatR;
using Product.Application.Features.Skus.Queries;
using Product.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Product.API.Resolvers
{
    [ExtendObjectType("Skus")]
    public class SkuResolver
    {
        public Task<IEnumerable<SKU>> GetSkusAsync([Parent] Option option, [Service] IMediator mediator, CancellationToken cancellationToken) =>
            mediator.Send(new GetSkusListByOptionId(option.Id), cancellationToken);
    }
}
