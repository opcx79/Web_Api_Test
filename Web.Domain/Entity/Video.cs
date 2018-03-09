using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Domain.Entity
{
    public class Video : Abstract.Audit
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

    }
}
