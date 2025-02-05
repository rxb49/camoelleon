using camouelleon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace camouelleon
{
    public partial class ArchiveFacture : Form
    {
        public ArchiveFacture()
        {
            InitializeComponent();
            dgvArchive.CellContentDoubleClick += dgvArchive_CellContentDoubleClick;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArchiveFacture_Load(object sender, EventArgs e)
        {
            bsArchive.DataSource = dgvArchive.DataSource = Modele.CommandesFiniesAvecFacture();
            dgvArchive.DataSource = bsArchive;

            dgvArchive.Columns["Idcommande"].HeaderText = "N° Commande";
            dgvArchive.Columns["Nbclient"].HeaderText = "Nombre de clients";
            dgvArchive.Columns["MontantTotal"].HeaderText = "Montant total (€)";
            dgvArchive.Columns["IdTable"].HeaderText = "N° Table";
            dgvArchive.Columns["Zone"].HeaderText = "N° Table";
            dgvArchive.Columns["Zone"].HeaderText = "Zone";
            dgvArchive.Columns["NbPlaces"].HeaderText = "Nombre de places";

            dgvArchive.AutoResizeColumns();
            nmMontant.Value = 0;
            Modele.Table().Insert(0, new Table { Idtable = -1, Idzone = 1 });

            bsTable.DataSource = Modele.Table();
            cbTable.DisplayMember = "Idtable";
            cbTable.ValueMember = "Idtable";
            cbTable.DataSource = bsTable;
            cbTable.Text = "Sélectionner une table";

        }

        private void RefreshDataGridView()
        {
            bsArchive.DataSource = Modele.CommandesFiniesAvecFacture();

            dgvArchive.DataSource = bsArchive;
            dgvArchive.Refresh();
        }

        private void dgvArchive_CellContentDoubleClick(object sender, EventArgs e)
        {
            if (dgvArchive.CurrentRow != null)
            {
                int idCommande = Convert.ToInt32(dgvArchive.CurrentRow.Cells["Idcommande"].Value);

                DialogResult result = MessageBox.Show(
                    $"Voulez-vous vraiment modifier l'état de la commande {idCommande} ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Modele.MettreEtatFactureA3(idCommande);
                    RefreshDataGridView();
                }
            }
        }

        private void nmMontant_ValueChanged(object sender, EventArgs e)
        {
            decimal montantFiltre = nmMontant.Value;

            bsArchive.DataSource = Modele.FacturePayeByMontant(montantFiltre);
            dgvArchive.DataSource = bsArchive;

            if (bsArchive.Count == 0)
            {
                MessageBox.Show("Aucune commande ne correspond au montant sélectionné.", "Filtrage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvArchive.AutoResizeColumns();
        }

        private void cbFacture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTable.SelectedValue == null) return;

            var selectedTableId = (int)cbTable.SelectedValue;

            // Si "Toutes les tables" est sélectionné
            if (selectedTableId == -1)
            {
                bsArchive.DataSource = dgvArchive.DataSource = Modele.CommandesFiniesAvecMontant();
            }
            else
            {
                // Filtrer les commandes en fonction de la table sélectionnée
                var filteredFactures = Modele.FactureAPayeByTable(selectedTableId);
                bsArchive.DataSource = dgvArchive.DataSource = filteredFactures;
            }

            if (bsArchive.Count == 0)
            {
                MessageBox.Show("Aucune commande ne correspond au montant sélectionné.", "Filtrage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvArchive.AutoResizeColumns();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsArchive.DataSource = dgvArchive.DataSource = Modele.CommandesFiniesAvecFacture();
            dgvArchive.DataSource = bsArchive;
        }
    }
}
