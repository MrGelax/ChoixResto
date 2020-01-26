using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    [Table("Restos")]
    public class Resto
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }

    }
}