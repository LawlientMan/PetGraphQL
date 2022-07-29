using HotChocolate.Types;

namespace Product.API.Queries
{
    public class StyleQueryType : ObjectTypeExtension<StyleQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<StyleQuery> descriptor) =>
            descriptor.Name("Query").Field(f => f.GetStylesAsync(default));
    }
}
