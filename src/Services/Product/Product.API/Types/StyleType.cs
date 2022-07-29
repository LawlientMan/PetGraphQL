using HotChocolate.Types;
using Product.Domain.Entities;

namespace Product.API.Types
{
    public class StyleType : ObjectType<Style>
    {
        protected override void Configure(IObjectTypeDescriptor<Style> descriptor)
        {
            descriptor.BindFieldsImplicitly();

            //descriptor.Field(_ => _.Id);
            //descriptor.Field(_ => _.CategoryId);
            //descriptor.Field(_ => _.Name);
            //descriptor.Field(_ => _.Description);
            //descriptor.Field(_ => _.Price);
            //descriptor.Field(_ => _.Quantity);

            //// Creates the relationship between Product x Category
            //descriptor.Field<CategoryResolver>(_ => _.GetCategoryAsync(default, default));
        }
    }
}
