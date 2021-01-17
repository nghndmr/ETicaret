using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
    [Table("ClientAddresses", Schema = "Management")]
    public class ClientAddress
    {
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public AdressType Type { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}
