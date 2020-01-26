using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public class Dal:IDal
    {
        private DbContextBis db;

        public Dal()
        {
            db = new DbContextBis();
        }
        public List<Resto> ObtientTouslesRestos()
        {
            return db.restos.ToList();
        }
        public void Dispose()
        {
            db.Dispose();
        }
        public void CreerResto(string name,string phoneNumber)
        {
            db.restos.Add(new Resto { name = name, phoneNumber = phoneNumber });
            db.SaveChanges();
        }
        public void ModifResto(int id,string name,string phoneNumber)
        {
            Resto restofind = db.restos.FirstOrDefault(resto=>resto.id==id);
            if (restofind != null)
            {
                restofind.name=name;
                restofind.phoneNumber=phoneNumber;
                db.SaveChanges();
            }
        }
        public bool RestaurantExiste(string name)
        {
            return db.restos.Any(resto => string.Compare(resto.name,name,StringComparison.CurrentCultureIgnoreCase)==0);
        }
        public User ObtenirUtilisateur(string id)
        {
            return db.users.FirstOrDefault(u=>""+u.id==id);
        }
    }
}