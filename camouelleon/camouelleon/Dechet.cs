using camouelleon.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Dechet : Form
    {
        public Dechet()
        {

            InitializeComponent();

            bsDechet.DataSource = Modele.Dechets();
            dgvDechets.DataSource = bsDechet;
            dgvDechets.Columns["Idproduits"].Visible = false;

            // Modifier les noms des colonnes de la DataGridView
            dgvDechets.Columns["Datejeter"].HeaderText = "Date du déchet";
            dgvDechets.Columns["Iddechet"].HeaderText = "Déchet";

            // Associer les produits au ComboBox
            bsProduit.DataSource = Modele.Produits();
            cbProduit.DisplayMember = "Lblproduit";
            cbProduit.ValueMember = "Idproduit";
            cbProduit.DataSource = bsProduit;
        }

        private void RefreshDataGridView()
        {
            bsDechet.DataSource = Modele.Dechets();

            dgvDechets.DataSource = bsDechet;
            dgvDechets.Refresh();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer le produit sélectionné dans le ComboBox
                var produit = (Produit)cbProduit.SelectedItem;

                // Récupérer la quantité sélectionnée dans le NumericUpDown
                int quantite = (int)nmQuantite.Value;

                // Récupérer la date sélectionnée dans le DateTimePicker
                DateOnly date = DateOnly.FromDateTime(dtpDate.Value);

                // Appeler la méthode AjouterDechet
                bool success = Modele.AjouterDechet(produit, quantite, date);

                // Afficher un message en fonction du résultat
                if (success)
                {
                    MessageBox.Show("Déchet ajouté avec succès.");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du déchet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void nmQuantite_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
