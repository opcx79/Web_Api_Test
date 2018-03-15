using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Web.Domain.Abstracts;

namespace Web.Domain.Entities
{
    public class Video : Auditable<System.Guid>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string TrillerUrl { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
