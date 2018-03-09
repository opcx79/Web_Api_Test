using System;

namespace Web.Domain.Entity.Abstract
{
    public abstract class Audit
    {
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
