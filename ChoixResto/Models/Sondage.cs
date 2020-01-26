using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public class Sondage
    {

        public int id { get; set; }
        public DateTime date { get; set; }
        public virtual List<Vote> votes { get; set;}
    }
}