using System;
using System.Collections.Generic;

namespace AuthWithIdentity.DomainObjects
{
    public class Tour: EntityBase
    {
        public Tour()
        {
        }
        public string Name { get; set; }
        public ICollection<Variant> Variants { get; set; }
    }
}
