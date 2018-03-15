using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Domain.Abstracts
{
    public interface IAuditable
    {
        [Required]
        string CreatedBy { get; set; }
        DateTime DateCreated { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}
