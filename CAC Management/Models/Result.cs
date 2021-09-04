using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CAC_Management.Models
{
    public class Result
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }
        public string Performance { get; set; }

    }
}
