namespace Product.Domain.Entities
{
    public sealed class SKU : Entity
    {
        public string SkuId { get; set; }
        public string Edp { get; set; }
        public string Ean { get; set; }
    }
}