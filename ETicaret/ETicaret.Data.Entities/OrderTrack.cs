using ETicaret.Common.Contracts.Enums;
using ETicaret.Data.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
    [Table("OrderTrack", Schema = "Order")]
    public class OrderTrack: EntityBase
    {
        [Required]
        public Guid OrderId { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
    }
}
