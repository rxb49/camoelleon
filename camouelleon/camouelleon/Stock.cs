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
    public partial class Stock : Form
    {

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
        public Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            FilterStockByProductName(""); // Par défaut, pas de filtre

            bsStock.DataSource = Modele.ListAllStock().Select(x => new
            {
                Produit = x.IdproduitNavigation.Lblproduit,
                Stock = x.IdstockNavigation.Lblstock,
                x.Quantite,
                Allergie = x.IdproduitNavigation.Idallergies.Any()
                    ? string.Join(", ", x.IdproduitNavigation.Idallergies.Select(a => a.Lblallergie))
                    : "Aucune allergie"
            }).ToList();
            dgvStock.DataSource = bsStock;
        }

        private void dgvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvStock.Rows[e.RowIndex];

                string produit = selectedRow.Cells["Produit"].Value.ToString();
                string stock = selectedRow.Cells["Stock"].Value.ToString();
                int quantite = Convert.ToInt32(selectedRow.Cells["Quantite"].Value);
                openChildForm(new AjoutStock(produit, stock, quantite));
            }
        }

        private void pnl_SF_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AjoutProduit(this));
        }

        public void RefreshStockDataGridView()
        {
            bsStock.DataSource = Modele.ListAllStock().Select(x => new
            {
                Produit = x.IdproduitNavigation.Lblproduit,
                Stock = x.IdstockNavigation.Lblstock,
                x.Quantite,
                Allergie = x.IdproduitNavigation.Idallergies.Any()
                            ? string.Join(", ", x.IdproduitNavigation.Idallergies.Select(a => a.Lblallergie))
                            : "Aucune allergie" // Affiche "Aucune allergie" si aucune allergie n'est associée
            }).ToList();

            dgvStock.DataSource = bsStock;
            dgvStock.Refresh();
        }

        private void FilterStockByProductName(string searchText)
        {
            var filteredStock = Modele.ListAllStock()
                .Where(x => x.IdproduitNavigation.Lblproduit.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .Select(x => new
                {
                    Produit = x.IdproduitNavigation.Lblproduit,
                    Stock = x.IdstockNavigation.Lblstock,
                    x.Quantite,
                    Allergie = x.IdproduitNavigation.Idallergies.Any()
                                ? string.Join(", ", x.IdproduitNavigation.Idallergies.Select(a => a.Lblallergie))
                                : "Aucune allergie"
                }).ToList();

            bsStock.DataSource = filteredStock;
            dgvStock.DataSource = bsStock;
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchProduit_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchProduit.Text.Trim(); // Récupérer le texte entré par l'utilisateur
            FilterStockByProductName(searchText); // Appliquer le filtre
        }
    }
}
