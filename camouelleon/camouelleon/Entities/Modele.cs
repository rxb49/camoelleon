using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camouelleon.Entities
{
    public static class Modele
    {
        
        private static CamoelleonContext monModel;
        public static void init()
        {
            monModel = new CamoelleonContext();
        }

        public static Allergie PremiereAllergie()
        {
            return monModel.Allergies.FirstOrDefault();
        }


    }
}
