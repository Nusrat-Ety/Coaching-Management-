using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CAC_Management.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        // [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]

        
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public int Contact { get; set; }
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter valid email")]
        public string Email { get; set; }
        public string Password { get; set; }

       
    }
}
