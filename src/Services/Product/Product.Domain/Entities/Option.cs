using System.Collections.Generic;

namespace Product.Domain.Entities
{
    public sealed class Option : Entity
    {
        public string ColourCode { get; set; }
        public string ColourName { get; set; }
        public string ColourGroup { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string PdpUrl { get; set; }
        public ICollection<string> CalculatedBulletPoints { get; set; }
    }   
}
