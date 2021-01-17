using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Data.Entity.Abstractions
{
    public class EntityBase : IEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }

}
