using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Web.Domain.Abstracts;

namespace Web.Domain.Entities
{
    public class Tag : Auditable<System.Guid>
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}