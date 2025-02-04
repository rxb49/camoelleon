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
    }
}
