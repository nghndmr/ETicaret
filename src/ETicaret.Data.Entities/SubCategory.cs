using ETicaret.Data.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
        [Table("SubCategories", Schema = "Production")]
        public class SubCategory : EntityBase
        {
            [Required]
            [MaxLength(30)]
            public string Name { get; set; }
            [MaxLength(30)]
            public Guid CategoryId { get; set; }
        }
    
}
