using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Domain.Abstracts
{
    public interface IAuditable
    {
        string CreatedBy { get; set; }
        DateTime DateCreated { get; set; }
        string UpdatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
