using ETicaret.Data.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
    [Table("OrderDetail", Schema = "Order")]
    public class OrderDetail: EntityBase
    {
        [Required]
        public Guid OrderId { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public byte Amount { get; set; }
        [Required]
        public byte Price { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }

    }
}
