using MediatR;
using Product.Domain.Entities;
using System;

namespace Product.Application.Features.Styles.Queries
{
    public class GetStyleByIdQuery : IRequest<Style>
    {
        public Guid Id { get; set; }

        public GetStyleByIdQuery(Guid id)
        {
            Id = id;    
        }
    }
}
