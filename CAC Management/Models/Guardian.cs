using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CAC_Management.Models
{
    public class Guardian
    {
        [Key]
        public int GuardianId { get; set; }
        public string GuardianName { get; set; }
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Contact { get; set; }
        public string Address { get; set; }
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter valid email")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
