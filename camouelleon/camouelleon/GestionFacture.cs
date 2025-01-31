using camouelleon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camouelleon
{
    public partial class GestionFacture : Form
    {
        public GestionFacture()
        {
            InitializeComponent();
        }
        public Form activeForm = null;

        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            pnl_SF.Controls.Add(formEnfant);
            pnl_SF.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void GestionFacture_Load(object sender, EventArgs e)
        {
            bsCommande.DataSource = dgvFacture.DataSource = Modele.CommandesFiniesAvecMontant();
            dgvFacture.DataSource = bsCommande;
        }
        private void RefreshDataGridView()
        {
            bsCommande.DataSource = Modele.CommandesFiniesAvecMontant();

            dgvFacture.DataSource = bsCommande;
            dgvFacture.Refresh();
        }
        private void dgvFacture_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = dgvFacture.Rows[e.RowIndex];

                    int idCommande = Convert.ToInt32(selectedRow.Cells["Idcommande"].Value);
                    int nbClient = Convert.ToInt32(selectedRow.Cells["Nbclient"].Value);
                    int montantTotal = Convert.ToInt32(selectedRow.Cells["MontantTotal"].Value);

                    string factureContenu = $"Facture N° {idCommande}\n";
                    factureContenu += $"Nombre de clients: {nbClient}\n";
                    factureContenu += $"Montant total: {montantTotal} EUR\n";
                    factureContenu += "---------------------------------\n";
                    factureContenu += "Merci de votre commande!\n";

                    string cheminFichier = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Facture_{idCommande}.txt");

                    File.WriteAllText(cheminFichier, factureContenu);
                    MessageBox.Show($"La facture a été générée avec succès et enregistrée sur le bureau sous le nom 'Facture_{idCommande}.txt'.");

                    Modele.MettreEtatFactureA5(idCommande);
                    RefreshDataGridView();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }
    }
}
