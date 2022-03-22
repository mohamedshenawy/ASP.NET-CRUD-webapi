using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace taskDay7.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "length shoud be smaller than 20")]
        public string Name { get; set; }
        [DataType(DataType.Password), MinLength(8, ErrorMessage = "length shoud be equal or greater than 8")]
        [Required]
        public string Password { get; set; }
    }
}