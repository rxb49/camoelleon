using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace camouelleon.Entities
{
    public static class Modele
    {
        
        private static CamoelleonContext monModel;
        public static void init()
        {
            monModel = new CamoelleonContext();
        }

        public static List<Allergie> Allergies()
        {
            return monModel.Allergies.ToList();
        }

        public static Utilisateur Utilisateur(string email)
        {
            return monModel.Utilisateurs.FirstOrDefault(u => u.Email == email);
        }

        public static List<Produit> GetProduitByType(int type)
        {
            List <Produit> lesPorduit = monModel.Produits.Where(p => p.Idtype ==
           type).ToList();
            return lesPorduit;
        }

    }


}

