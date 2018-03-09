using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Domain.Entity
{
    public class Tag
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}