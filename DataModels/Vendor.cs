using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels
{
   public class Vendor
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Entity")]
        public int EntityId { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime DateRegistered { get; }

        public bool IsActive { get; set; }
    }



}
