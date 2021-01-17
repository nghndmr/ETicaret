using ETicaret.Data.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
    [Table("Inveices",Schema= "Order")]
    public class Invoice: EntityBase
    {
        public Guid OrderId { get; set; }
        public Guid Supplier { get; set; }
        public int InvoiceNumber { get; set; }
        public Guid ClientAddressId { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier SupplierId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }
        
        //TODO: Client Address client navigation property
    }
}
