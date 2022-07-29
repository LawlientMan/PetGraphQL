using HotChocolate.Types;
using Product.Domain.Entities;

namespace Product.API.Types
{
    public class StyleType : ObjectType<Style>
    {
        protected override void Configure(IObjectTypeDescriptor<Style> descriptor)
        {
            descriptor.BindFieldsImplicitly();
        }
    }
}
