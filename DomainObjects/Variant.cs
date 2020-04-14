using System;
namespace AuthWithIdentity.DomainObjects
{
    public class Variant: EntityBase
    {
        public Variant()
        {
        }
        public Tour Tour { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
