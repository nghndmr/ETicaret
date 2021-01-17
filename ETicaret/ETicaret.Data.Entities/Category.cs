using ETicaret.Data.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
    [Table("Categories", Schema = "Production")]
    public class Category : EntityBase
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Description { get; set; }
    }
}
