using ETicaret.Data.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
    [Table("Baskets", Schema = "Order")]
    public class Basket:EntityBase
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        public byte Amount { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
    }
}
