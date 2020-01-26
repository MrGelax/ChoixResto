using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public class Vote
    {
        
        public int id { get; set; }
        public virtual Resto resto { get; set; }
        public virtual User user { get; set; }




    }
}