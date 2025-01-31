using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
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

        public static List<Produit> Produits()
        {
            return monModel.Produits.ToList();
        }

        public static List<Unite> listeUnite()
        {
            return monModel.Unites.ToList(); // Assurez-vous que `Unites` contient des données
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

        public static List<Typeproduit> TypeProduit()
        {
            return monModel.Typeproduits.ToList(); 
        }

        public static List<Stock> ListStock()
        {
            return monModel.Stocks.ToList();
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
            List<Produit> lesPorduit = monModel.Produits.Where(p => p.Idtype == type).ToList();
            return lesPorduit;
        }

        public static bool InsertCommande(int quantite, int idProduit, int idCommande)
        {
            Attribuer maCommande;
            bool vretour = true;
            try
            {
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
                .Where(r => r.Idproduit == id)
                .ToList();
        }

        public static bool UpdateStockById(string produit, int quantite, int stock)
        {
            Produit monproduit = RecupererProduit(produit);
            Stock monStock = RecupererStock(stock);

            if (monproduit == null || monStock == null)
            {
                MessageBox.Show("Produit ou stock introuvable.");
                return false;
            }

            try
            {
                // Trouver le rangement existant pour ce produit
                Ranger unrangement = monModel.Rangers.FirstOrDefault(r =>
                    r.Idproduit == monproduit.Idproduit);

                if (unrangement == null)
                {
                    MessageBox.Show("Aucun rangement trouvé pour ce produit.");
                    return false;
                }

                // 🔹 Supprimer l'ancien rangement
                monModel.Rangers.Remove(unrangement);
                monModel.SaveChanges(); // Enregistrer la suppression du rangement existant

                // 🔹 Créer un nouveau rangement avec les informations mises à jour
                Ranger nouveauRangement = new Ranger
                {
                    Idproduit = monproduit.Idproduit,
                    Idstock = monStock.Idstock, // Nouveau stock
                    Quantite = quantite
                };

                monModel.Rangers.Add(nouveauRangement);
                monModel.SaveChanges(); // Enregistrer le nouveau rangement

                MessageBox.Show("Modification réussie !");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
                return false;
            }
        }

        public static Produit RecupererProduit(string produit)
        {
            Produit monProduit = new Produit();
            try
            {
                monProduit = monModel.Produits.FirstOrDefault(x => x.Lblproduit == produit);
                if (monProduit == null)
                {
                    MessageBox.Show($"Produit '{produit}' introuvable dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du produit : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return monProduit;
        }

        public static Stock RecupererStock(int stock)
        {
            Stock monStock = new Stock();
            try
            {
                monStock = monModel.Stocks.FirstOrDefault(x => x.Idstock == stock);
                if (monStock == null)
                {
                    MessageBox.Show($"Stock '{stock}' introuvable dans la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du stock : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return monStock;
        }

        public static bool AddProduit(int lblunite, string produit, string type, int prix, int stock)
        {
            bool vretour = true;
            if (produit == "")
            {
                MessageBox.Show("Entrez un nom de produit");
            }
            if(prix <= 0)
            {
                MessageBox.Show("Rentrez une valeur supérieur à 0");
            }else
            {
                Produit newProduit;
                Typeproduit typeProduit = monModel.Typeproduits.FirstOrDefault(t => t.Id == Convert.ToInt32(type));
                Unite unite = monModel.Unites.FirstOrDefault(u => u.Idunite == lblunite);


                try
                {
                    newProduit = new Produit();
                    newProduit.Idunite = unite.Idunite;
                    newProduit.Lblunite = unite.Lblunite;
                    newProduit.Lblproduit = produit;
                    newProduit.Prixproduit = prix;
                    newProduit.Menudujour = 0;
                    newProduit.Idtype = typeProduit.Id;

                    monModel.Produits.Add(newProduit);
                    monModel.SaveChanges();

                    Ranger unrangement = new Ranger();
                    unrangement.Idstock = stock;
                    unrangement.Idproduit = newProduit.Idproduit;
                    unrangement.Quantite = 0;


                    monModel.Rangers.Add(unrangement);
                    monModel.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}\n{ex.InnerException?.Message}");
                    vretour = false;
                }
            }
            
            return vretour;
        }

        public static bool AddProduitToStock(string produit, int stock)
        {
            Produit monproduit = RecupererProduit(produit);
            Stock monStock = RecupererStock(stock);

            if (monproduit == null || monStock == null)
            {
                MessageBox.Show("Produit ou stock introuvable");
                return false;
            }

            try
            {
                Ranger unrangement = monModel.Rangers.FirstOrDefault(r =>
                    r.Idproduit == monproduit.Idproduit && r.Idstock == monStock.Idstock);

                if (unrangement == null)
                {
                    MessageBox.Show("Aucun rangement trouvé pour ce produit et ce stock.");
                    return false; // ou gérer la situation autrement
                }


                monModel.SaveChanges();

                MessageBox.Show("Modification réussie");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
                return false;
            }
        }

        public static object CommandesFiniesAvecMontant()
        {
            return monModel.Commandes
                .Where(c => c.Liers.Any(l => l.IdetatNavigation.Idetat == 3))
                .Include(c => c.Attribuers)
                    .ThenInclude(a => a.IdproduitNavigation)
                .Select(c => new
                {
                    c.Idcommande,
                    c.Nbclient,
                    MontantTotal = c.Attribuers.Sum(a => a.Quantite * a.IdproduitNavigation.Prixproduit)
                })
                .ToList();
        }


    }
}

