using System;
using System.Collections.Generic;
using System.Linq;
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

            //descriptor.Field(_ => _.CalculatedBulletPoints).Ignore();

            //descriptor.Field(_ => _.Id);
            //descriptor.Field(_ => _.CategoryId);
            //descriptor.Field(_ => _.Name);
            //descriptor.Field(_ => _.Description);
            //descriptor.Field(_ => _.Price);
            //descriptor.Field(_ => _.Quantity);

            //// Creates the relationship between Product x Category
            descriptor.Field<SkuResolver>(_ => _.GetSkusAsync(default, default));
        }
    }
}
