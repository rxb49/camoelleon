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

            dgvFacture.Columns["Idcommande"].HeaderText = "N° Commande";
            dgvFacture.Columns["Nbclient"].HeaderText = "Nombre de clients";
            dgvFacture.Columns["MontantTotal"].HeaderText = "Montant total (€)";

            dgvFacture.AutoResizeColumns();
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

                    StringBuilder factureContenu = new StringBuilder();
                    factureContenu.AppendLine("".PadRight(50, '='));
                    factureContenu.AppendLine("                    FACTURE");
                    factureContenu.AppendLine("".PadRight(50, '='));
                    factureContenu.AppendLine($"\nFacture N° : {idCommande}");
                    factureContenu.AppendLine($"Date : {DateTime.Now.ToShortDateString()}\n");
                    factureContenu.AppendLine("".PadRight(50, '-'));
                    factureContenu.AppendLine($"\nNombre de clients : {nbClient}");
                    factureContenu.AppendLine($"Montant total : {montantTotal} EUR\n");
                    factureContenu.AppendLine("".PadRight(50, '-'));
                    factureContenu.AppendLine("\nDétails de la commande :");
                    factureContenu.AppendLine($"Total à payer : {montantTotal} EUR");
                    factureContenu.AppendLine("\n".PadRight(50, '-'));
                    factureContenu.AppendLine("\nMerci de votre confiance !");
                    factureContenu.AppendLine("\n".PadRight(50, '='));

                    string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                    string filePath = Path.Combine(downloadsPath, $"Facture_{idCommande}.txt");

                    File.WriteAllText(filePath, factureContenu.ToString());

                    MessageBox.Show($"La facture a été générée avec succès et enregistrée dans le dossier Téléchargements sous le nom 'Facture_{idCommande}.txt'");
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
