using ETicaret.Data.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
    [Table("Products",Schema="Production")]
    public class Product:EntityBase
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string MainImageUrl  { get; set; }
        public Guid SupplierId { get; set; }
        public Guid SubCategoryId { get; set; }
        public Supplier Supplier { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
