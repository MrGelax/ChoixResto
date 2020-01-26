using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public interface IDal:IDisposable
    {
        List<Resto> ObtientTouslesRestos();
        void CreerResto(string name, string phoneNumber);
        void ModifResto(int id,string name,string phoneNumber);
        bool RestaurantExiste(string name);
        User GetUser(string id);
    }
}