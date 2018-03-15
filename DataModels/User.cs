using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels
{
  public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(12), MinLength(6)]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("Entity")]
        public int EntityId { get; set; }
        [ForeignKey("Vendor")]
         public int VendorId { get; set; }
    }
}
