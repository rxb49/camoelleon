using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public static List<Commande> Commande()
        {
            return monModel.Commandes.ToList();
        }
        public static List<Etat> Etat()
        {
            return monModel.Etats.ToList();
        }

        public static List<Commande> CommandeWithEtat()
        {
            return monModel.Commandes.Include(c => c.Liers)
                  .ThenInclude(l => l.IdetatNavigation)
                  .Include(t => t.Idtables)
                  .Include(f => f.Factures)
                  .ToList();
        }

        public static List<Produit> GetProduitByType(int type)
        {
            List <Produit> lesPorduit = monModel.Produits.Where(p => p.Idtype ==
           type).ToList();
            return lesPorduit;
        }

        public static bool InsertCommande(int quantite, int idProduit, int idCommande)
        {
            Attribuer maCommande;
            bool vretour = true;
            try { 
                maCommande = new Attribuer();
                maCommande.Quantite = quantite;
                maCommande.Idproduit = idProduit; 
                maCommande.Idcommande = idCommande;

                monModel.Attribuers.Add(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show("Erreur lors de l\'ajout");
            }
            return vretour;
        }

        public static List<Commande> CommandeByEtat(int etat)
        {
            return monModel.Commandes
                .Where(c => c.Liers.Any(l => l.IdetatNavigation.Idetat == etat))
                .Include(c => c.Liers)
                  .ThenInclude(l => l.IdetatNavigation)
                  .Include(t => t.Idtables)
                  .Include(f => f.Factures)
                  .ToList();
        }

        public static List<Commande> CommandeByMontant(decimal montant)
        {
            return monModel.Commandes
                .Include(c => c.Liers)
                  .ThenInclude(l => l.IdetatNavigation)
                  .Include(t => t.Idtables)
                  .Include(f => f.Factures)
                  .Where(c => c.Factures.Any(f => f.Montant >= montant))
                  .ToList();
        }


        public static List<Ranger> ListAllStock()
        {
            return monModel.Rangers
                .Include(p => p.IdproduitNavigation)
                .Include(s => s.IdstockNavigation)
                .ToList();
        }

        public static List<Ranger> ListStockById(int id)
        {
            return monModel.Rangers
                .Include(p => p.IdproduitNavigation)
                .Include(s => s.IdstockNavigation)
                .Where(r => r.Idproduit ==  id)
                .ToList();
        }
    }


}

