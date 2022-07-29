using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.API.Queries
{
    public class StyleQueryType : ObjectTypeExtension<StyleQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<StyleQuery> descriptor) =>
            descriptor.Name("Query").Field(f => f.GetProductsAsync());
    }
}
