using System;

namespace Web.Domain.Abstracts
{
    public abstract class Auditable<T> : Entity<T>, IAuditable
    {
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}