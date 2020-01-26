using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ChoixResto.Models
{
    public class DbContextBis: DbContext
    {
        public DbSet<Sondage> sondages { get; set; }
        public DbSet<Resto> restos { get; set; }
        public DbSet<User> users { get; set; }

    }
}