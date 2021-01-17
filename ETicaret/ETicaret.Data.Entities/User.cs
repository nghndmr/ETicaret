using ETicaret.Common.Contracts;
using ETicaret.Data.Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETicaret.Data.Entities
{
    [Table("Users",Schema="Management")]
    public class User:EntityBase
    {
        [Required]
        [MaxLength(40)]
        public string UserName { get; set; }
        [MaxLength(60)]
        public string DisplayName { get; set; }
        [Required]
        [MaxLength(64)]
        public string Password { get; set; }
        [Required]
        public UserType Type { get; set; }
        [MaxLength(40)]
        public string VerificationCode { get; set; }
    }
}
