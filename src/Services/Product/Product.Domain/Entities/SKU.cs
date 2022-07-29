using System;
namespace Product.Domain.Entities
{
    public sealed class SKU : Entity
    {
        public Guid OptionId { get; set; }
        public string SkuId { get; set; }
        public string Edp { get; set; }
        public string Ean { get; set; }
    }
}