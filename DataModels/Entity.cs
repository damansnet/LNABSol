using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataModels
{
  public  class Entity
    {
        [Key]
        
       public int Id { get; set; }

        [Required]
        public string EngityName { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Vendor> Vendors { get; set; }
    }
}
