using HotChocolate.Types;
using Product.API.Resolvers;
using Product.Domain.Entities;

namespace Product.API.Types
{
    public class OptionType : ObjectType<Option>
    {
        protected override void Configure(IObjectTypeDescriptor<Option> descriptor)
        {
            descriptor.BindFieldsImplicitly();
            descriptor.Field<SkuResolver>(_ => _.GetSkusAsync(default, default));
        }
    }
}
