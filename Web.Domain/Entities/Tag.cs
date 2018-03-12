using System.Collections.Generic;
using Web.Domain.Abstracts;

namespace Web.Domain.Entities
{
    public class Tag : Auditable<System.Guid>
    {
        public string Name { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}