using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthWithIdentity.DomainObjects
{
    public class Tour: EntityBase
    {
        public Tour()
        {
        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public virtual decimal PseudoPrice { get => GetPseudoPrice(); }
        public virtual decimal Price { get => GetPrice(); }
        public ICollection<Variant> Variants { get; set; }

        private decimal GetPseudoPrice()
        {
            if (Variants == null)
                return 0;
            List<decimal> pseudopricelist = new List<decimal>();
            foreach (var item in Variants)
            {
                pseudopricelist.Add(item.PseudoPrice);
            }
            return pseudopricelist.Min();
        }

        private decimal GetPrice()
        {
            if (Variants == null)
                return 0;
            List<decimal> pseudopricelist = new List<decimal>();
            foreach (var item in Variants)
            {
                pseudopricelist.Add(item.Price);
            }
            return pseudopricelist.Min();
        }
    }
}
