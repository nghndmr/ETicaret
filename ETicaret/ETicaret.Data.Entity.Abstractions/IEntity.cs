using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Data.Entity.Abstractions
{
    public class IEntity
    {
        Guid Id { get; set; }
        DateTime Created { get; set; }
        Guid CreatedBy { get; set; }
        Guid UpdatedBy { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; }
    }
}
