using MediatR;
using Product.Application.Contracts.Persistence;
using Product.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Application.Features.Styles.Queries
{
    public class StyleQuerisHandler : IRequestHandler<GetStylesListQuery, IEnumerable<Style>>,
                                      IRequestHandler<GetStyleByIdQuery, Style>
    {
        private readonly IStyleRepository styleRepository;

        public StyleQuerisHandler(IStyleRepository styleRepository)
        {
            this.styleRepository = styleRepository;
        }

        public async Task<IEnumerable<Style>> Handle(GetStylesListQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Style> styles = await styleRepository.GetAllAsync();

            return styles;
        }

        public async Task<Style> Handle(GetStyleByIdQuery request, CancellationToken cancellationToken)
        {
            Style style = await styleRepository.GetByIdAsync(request.Id);

            return style;
        }
    }
}
