using HotChocolate;
using MediatR;
using Product.Application.Contracts.Persistence;
using Product.Application.Features.Styles.Queries;
using Product.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.API.Queries
{
    public class StyleQuery
    {
        private readonly IMediator mediator;
        public StyleQuery(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<IEnumerable<Style>> GetProductsAsync() => mediator.Send(new GetStylesListQuery());

        public Task<Style> GetProductById(string id) => mediator.Send(new GetStyleByIdQuery(new Guid(id)));
    }
}
