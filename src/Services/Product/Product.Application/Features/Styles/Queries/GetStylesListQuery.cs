using MediatR;
using Product.Domain.Entities;
using System.Collections.Generic;

namespace Product.Application.Features.Styles.Queries
{
    public class GetStylesListQuery : IRequest<IEnumerable<Style>>
    {
    }
}
