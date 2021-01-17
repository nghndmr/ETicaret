using ETicaret.Data.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
    [Table("Orders",Schema= "Order")]
    public class Order:EntityBase
    {
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal Total { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}
