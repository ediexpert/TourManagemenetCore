using System;
using System.ComponentModel.DataAnnotations;

namespace AuthWithIdentity.DomainObjects
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; protected set; }
    }
}
