using camouelleon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camouelleon
{
    public partial class CreateFacture : Form
    {
        public CreateFacture()
        {
            InitializeComponent();
        }

        public CreateFacture(int idCommande, int nbClient, int montantTotal)
        {
            InitializeComponent();


            txtCommande.Text = idCommande.ToString();
            txtClient.Text = nbClient.ToString();
            txtMontant.Text = montantTotal.ToString();
        }

        private void BtnGenererFacture_Click(object sender, EventArgs e)
        {
            // Récupération des données des champs
            int idCommande = int.Parse(txtCommande.Text);
            int nbClient = int.Parse(txtClient.Text);
            int montantTotal = int.Parse(txtMontant.Text);

            // Création d'une chaîne qui contient les informations de la facture
            string factureContenu = $"Facture N° {idCommande}\n";
            factureContenu += $"Nombre de clients: {nbClient}\n";
            factureContenu += $"Montant total: {montantTotal} EUR\n";
            factureContenu += "---------------------------------\n";
            factureContenu += "Merci de votre commande!\n";

            // Spécifier le chemin et le nom du fichier
            string cheminFichier = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Facture_{idCommande}.txt");

            // Enregistrement de la facture dans le fichier texte
            try
            {
                File.WriteAllText(cheminFichier, factureContenu);
                MessageBox.Show($"La facture a été générée avec succès et enregistrée sur le bureau sous le nom 'Facture_{idCommande}.txt'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la génération de la facture : {ex.Message}");
            }

            // Mettre à jour l'état de la commande sélectionnée à 5
            Modele.MettreEtatFactureA5(idCommande);

            MessageBox.Show("La facture a été mise à jour avec succès.");


        }
    }
}
