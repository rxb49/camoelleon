using camouelleon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

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
            dgvFacture.Columns["IdTable"].HeaderText = "N° Table";
            dgvFacture.Columns["Zone"].HeaderText = "N° Table";
            dgvFacture.Columns["Zone"].HeaderText = "Zone";
            dgvFacture.Columns["NbPlaces"].HeaderText = "Nombre de places";
            dgvFacture.AutoResizeColumns();


            bsTable.DataSource = Modele.Table();
            cbTable.DisplayMember = "Idtable";
            cbTable.ValueMember = "Idtable";
            cbTable.DataSource = bsTable;


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
                    DialogResult result = MessageBox.Show(
                    $"Voulez-vous vraiment modifier l'état de la commande {idCommande} ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                    if (result == DialogResult.Yes)
                    {
                        // Créer le contenu HTML de la facture
                        string htmlContent = $@"
                            <!DOCTYPE html>
                            <html>
                            <head>
                                <meta charset='utf-8'>
                                <style>
                                    body {{ font-family: Arial, sans-serif; margin: 40px; }}
                                    .facture-header {{ text-align: center; margin-bottom: 30px; }}
                                    .facture-details {{ margin-bottom: 20px; }}
                                    .facture-table {{ width: 100%; border-collapse: collapse; margin: 20px 0; }}
                                    .facture-table th, .facture-table td {{ 
                                        border: 1px solid #ddd; 
                                        padding: 8px; 
                                        text-align: left; 
                                    }}
                                    .total {{ text-align: right; margin-top: 20px; }}
                                    .footer {{ text-align: center; margin-top: 50px; }}
                                </style>
                            </head>
                            <body>
                                <div class='facture-header'>
                                    <h1>FACTURE</h1>
                                    <h2>N° {idCommande}</h2>
                                    <p>Date: {DateTime.Now.ToShortDateString()}</p>
                                </div>
                
                                <div class='facture-details'>
                                    <p><strong>Nombre de clients:</strong> {nbClient}</p>
                                </div>

                                <table class='facture-table'>
                                    <tr>
                                        <th>Description</th>
                                        <th>Montant</th>
                                    </tr>
                                    <tr>
                                        <td>Total des services</td>
                                        <td>{montantTotal} EUR</td>
                                    </tr>
                                </table>

                                <div class='total'>
                                    <h3>Total à payer: {montantTotal} EUR</h3>
                                </div>

                                <div class='footer'>
                                    <p>Merci de votre confiance!</p>
                                    <p>Pour toute question, veuillez nous contacter.</p>
                                </div>
                            </body>
                            </html>";

                        // Chemin du fichier dans le dossier Téléchargements
                        string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                        string htmlPath = Path.Combine(downloadsPath, $"Facture_{idCommande}.html");

                        // Sauvegarder le fichier HTML
                        File.WriteAllText(htmlPath, htmlContent, System.Text.Encoding.UTF8);

                        MessageBox.Show($"La facture a été générée avec succès et enregistrée dans le dossier Téléchargements sous le nom 'Facture_{idCommande}.html'.");
                        Modele.MettreEtatFactureA5(idCommande);
                        RefreshDataGridView();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nmMontant_ValueChanged(object sender, EventArgs e)
        {
            decimal montantFiltre = nmMontant.Value;

            bsCommande.DataSource = Modele.FactureAPayeByMontant(montantFiltre);
            dgvFacture.DataSource = bsCommande;

            if (bsCommande.Count == 0)
            {
                MessageBox.Show("Aucune commande ne correspond au montant sélectionné.", "Filtrage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvFacture.AutoResizeColumns();
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTableId = (int)cbTable.SelectedValue;

            // Filtrer les commandes en fonction de la table sélectionnée
            var filteredFactures = Modele.FactureAPayeByTable(selectedTableId);

            // Afficher les données filtrées dans la DataGridView
            bsCommande.DataSource = dgvFacture.DataSource = filteredFactures;
            dgvFacture.DataSource = bsCommande;

            if (bsCommande.Count == 0)
            {
                MessageBox.Show("Aucune commande ne correspond au montant sélectionné.", "Filtrage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Redimensionner les colonnes
            dgvFacture.AutoResizeColumns();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsCommande.DataSource = dgvFacture.DataSource = Modele.CommandesFiniesAvecMontant();
            dgvFacture.DataSource = bsCommande;
        }
    }
}
