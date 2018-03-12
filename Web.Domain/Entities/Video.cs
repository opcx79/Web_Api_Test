using System.Collections.Generic;
using Web.Domain.Abstracts;

namespace Web.Domain.Entities
{
    public class Video : Auditable<System.Guid>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
