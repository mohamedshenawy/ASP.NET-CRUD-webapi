using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace taskDay7.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "length shoud be smaller than 20")]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public int Grade { get; set; }
    }
}