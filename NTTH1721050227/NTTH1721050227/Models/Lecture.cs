using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTTH1721050227.Models
{
    public class Lecture : Person
    {
        [Key]
        [StringLength(50)]
        public string Faculty { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
    }
}