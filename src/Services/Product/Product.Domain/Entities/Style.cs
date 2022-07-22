using System.Collections.Generic;

namespace Product.Domain.Entities
{
    public sealed class Style : Entity
    {
        public string StyleCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PdpUrl { get; set; }
        public ICollection<Option> Options { get; set; }
    }
}
