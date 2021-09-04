using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CAC_Management.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string Name { get; set; }
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter valid email")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
