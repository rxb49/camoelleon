using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using camouelleon.Entities;

namespace camouelleon.Modele
{
    internal class Modele
    {

        private static BdPartitionsContext monModel;
        public static void init()
        {
            monModel = new BdPartitionsContext();
        }

        public static List<Allergie> listeClients()
        {
            return monModel.Allergie.ToList();
        }
    }
}
