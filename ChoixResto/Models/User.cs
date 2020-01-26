using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
    }
}