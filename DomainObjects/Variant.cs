using System;
namespace AuthWithIdentity.DomainObjects
{
    public class Variant: EntityBase
    {
        public Variant()
        {
        }
        
        public string Name { get; set; }
        public decimal PseudoPrice { get; set; }
        public decimal Price { get; set; }
        public Tour Tour { get; set; }
    }
}
